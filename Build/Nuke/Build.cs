using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.AzurePipelines;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
[GitHubActions(
    "continuous",
    GitHubActionsImage.WindowsLatest,
    AutoGenerate = false,
    On = new[] { GitHubActionsTrigger.Push },
    EnableGitHubContext = true,
    InvokedTargets = new[] { nameof(Test), nameof(Pack) })]
[GitHubActions(
    "continuousCore",
    GitHubActionsImage.UbuntuLatest,
    GitHubActionsImage.MacOsLatest,
    AutoGenerate = false,
    On = new[] { GitHubActionsTrigger.Push },
    EnableGitHubContext = true,    
    InvokedTargets = new[] { nameof(TestCoreOnly) })]
[AzurePipelines(
    suffix: null,
    AzurePipelinesImage.WindowsLatest,
    AutoGenerate = false,
    InvokedTargets = new[] { nameof(Test), nameof(TestCoreOnly), nameof(Pack) },
    NonEntryTargets = new[] { nameof(Restore) },
    ExcludedTargets = new[] { nameof(Clean), nameof(PackCoreOnly)})]

partial class Build : Nuke.Common.NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Compile);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Solution] readonly Solution Solution;
    [GitRepository] readonly GitRepository GitRepository;
    [GitVersion(Framework = "net5.0")] readonly GitVersion GitVersion;

    [CI] readonly AzurePipelines AzurePipelines;


    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath ResultDirectory => RootDirectory / ".result";
    AbsolutePath PackagesDirectory => ResultDirectory / "packages";
    AbsolutePath TestResultDirectory => ResultDirectory / "test-results";
    IEnumerable<Project> TestProjects => Solution.GetProjects("*.Tests");
    IEnumerable<Project> AllProjects => Solution.AllProjects.Where(x=> SourceDirectory.Contains(x.Path));

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
            EnsureCleanDirectory(ResultDirectory);
        });

    Target Restore => _ => _
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(Solution));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() => ExecutesCompile(false));

    void ExecutesCompile(bool excludeNetFramework)
    {

        Serilog.Log.Information(excludeNetFramework ? "Exclude net framework" : "Include net framework");
        if (excludeNetFramework)
        {
            var projectWithFrameworkAndPlatform =
                from project in AllProjects
                from framework in project.GetTargetFrameworks(true)
                from platform in project.GetPlatforms()
                select new {project, framework, platform};


            DotNetBuild(s => s
                .SetConfiguration(Configuration)
                .SetNoRestore(InvokedTargets.Contains(Restore))
                .SetAssemblyVersion(GitVersion.AssemblySemVer)
                .SetFileVersion(GitVersion.AssemblySemFileVer)
                .SetInformationalVersion(GitVersion.InformationalVersion)
                .CombineWith(projectWithFrameworkAndPlatform, (s, f) => s
                    .SetFramework(f.framework)
                    .SetProperty("Platform", f.platform)
                    .SetProjectFile(f.project)));
        }
        else
        {
            DotNetBuild(s => s
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .EnableNoRestore()
                .SetAssemblyVersion(GitVersion.AssemblySemVer)
                .SetFileVersion(GitVersion.AssemblySemFileVer)
                .SetInformationalVersion(GitVersion.InformationalVersion));
        }
    }

    [Partition(4)] readonly Partition TestPartition;

    Target Test => _ => _
        .DependsOn(Compile) 
        .Produces(TestResultDirectory / "*.trx")
        .Partition(4)
        .Executes(() => ExecutesTest(false));

    void ExecutesTest(bool excludeNetFramework)
    {
        Serilog.Log.Information(excludeNetFramework ? "Exclude net framework" : "Include net framework");

        var groupTestConfigurations =
            (from project in TestProjects
            from framework in project.GetTargetFrameworks(excludeNetFramework)
            from platform in project.GetPlatformsForTests()
            select (project, framework, platform))
                .Filter(IsLocalBuild, AzurePipelines)
            .Group()
            .ToList();

        var testConfigurations = 
            TestPartition
                .GetCurrent(groupTestConfigurations)
                .SelectMany(x=>x);

        DotNetTest(_ =>
            {
                return _
                    .SetConfiguration(Configuration)
                    .SetNoRestore(InvokedTargets.Contains(Restore))
                    .SetNoBuild(InvokedTargets.Contains(Compile))
                    .ResetVerbosity()
                    .SetResultsDirectory(TestResultDirectory)
                    .CombineWith(testConfigurations, (_, v) => _
                        .SetProjectFile(v.project)
                        .SetFramework(v.framework)
                        .DisableNoBuild()
                        .SetProperty("Platform", v.platform)
                        .SetLoggers($"trx;LogFileName={v.project.Name}-{v.framework}.trx"));
            });

        TestResultDirectory.GlobFiles("*.trx").ForEach(x =>
            AzurePipelines?.PublishTestResults(
                type: AzurePipelinesTestResultsType.VSTest,
                title: $"{Path.GetFileNameWithoutExtension(x)} ({AzurePipelines.StageDisplayName})",
                files: new string[] {x}));
    }

    Target CompileCoreOnly => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            var excludeNetFramework = AllProjects.SelectMany(x => x.GetTargetFrameworks()).Distinct()
                .Any(x => !x.Contains("standard") || !x.Contains("core") || !x.Contains("net50"));
            ExecutesCompile(excludeNetFramework);
        });

    Target TestCoreOnly => _ => _
        .DependsOn(CompileCoreOnly)
        .Produces(TestResultDirectory / "*.trx")
        .Executes(() =>
        {
            var excludeNetFramework = AllProjects.SelectMany(x => x.GetTargetFrameworks()).Distinct()
                .Any(x => !x.Contains("standard") || !x.Contains("core") || !x.Contains("net50"));
            ExecutesTest(excludeNetFramework);
        });


    Target Pack => _ => _
        .DependsOn(Compile)
        .Produces(PackagesDirectory / "*.nupkg")
        .Executes(ExecutesPack);

    Target PackCoreOnly => _ => _
        .DependsOn(CompileCoreOnly)
        .Produces(PackagesDirectory / "*.nupkg")
        .Executes(ExecutesPack);


    void ExecutesPack() =>
        DotNetPack(_ =>
        {
            var repositoryUrl = $"https://{GitRepository.Endpoint}/{GitRepository.Identifier}/";

            return _    
                .SetProject(Solution)
                .SetNoRestore(InvokedTargets.Contains(Restore))
                .SetNoBuild(InvokedTargets.Contains(Compile))
                .SetConfiguration(Configuration)
                .SetOutputDirectory(PackagesDirectory)
                .DisablePackageRequireLicenseAcceptance()
                .SetRepositoryType("git")
                .SetRepositoryUrl(repositoryUrl)
                .SetProperty("RepositoryCommit", GitVersion.Sha)
                .SetPackageReleaseNotes($"{repositoryUrl}releases/v{GitVersion.MajorMinorPatch}")
                .SetAuthors("Reegeek")
                .SetProperty("Owners", "Reegeek")
                .SetPackageProjectUrl(repositoryUrl)
                .SetVersion(GitVersion.NuGetVersionV2);
        });
}