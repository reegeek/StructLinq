using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.AppVeyor;
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
    On = new[] { GitHubActionsTrigger.Push },
    ImportGitHubTokenAs = nameof(GitHubToken),
    InvokedTargets = new[] { nameof(Test), nameof(Pack) })]
[GitHubActions(
    "continuousCore",
    GitHubActionsImage.UbuntuLatest,
    GitHubActionsImage.MacOsLatest,
    On = new[] { GitHubActionsTrigger.Push },
    ImportGitHubTokenAs = nameof(GitHubToken),
    InvokedTargets = new[] { nameof(TestCoreOnly) })]
[AppVeyor(
    AppVeyorImage.VisualStudio2019,
    SkipTags = true,
    InvokedTargets = new[] { nameof(Test), nameof(Pack) })]
[AzurePipelines(
    suffix: null,
    AzurePipelinesImage.WindowsLatest,
    AzurePipelinesImage.UbuntuLatest,
    AzurePipelinesImage.MacOsLatest,
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
    [GitVersion] readonly GitVersion GitVersion;

    [CI] readonly AzurePipelines AzurePipelines;
    [Parameter("GitHub Token")] readonly string GitHubToken;

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
                .SetProjectFile(Solution)
                .AddProperty("CheckEolTargetFramework", false));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() => ExecutesCompile(false));

    void ExecutesCompile(bool excludeNetFramework)
    {
        Logger.Info(excludeNetFramework ? "Exclude net framework" : "Include net framework");
        if (excludeNetFramework)
        {
            var frameworks =
                from project in AllProjects
                from framework in project.GetTargetFrameworks(true)
                select new {project, framework};


            DotNetBuild(s => s
                .SetConfiguration(Configuration)
                .SetNoRestore(InvokedTargets.Contains(Restore))
                .SetAssemblyVersion(GitVersion.AssemblySemVer)
                .SetFileVersion(GitVersion.AssemblySemFileVer)
                .SetInformationalVersion(GitVersion.InformationalVersion)
                .AddProperty("CheckEolTargetFramework", false)
                .CombineWith(frameworks, (s, f) => s
                    .SetFramework(f.framework)
                    .SetProjectFile(f.project)));
        }
        else
        {
            DotNetBuild(s => s
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .EnableNoRestore()
                .AddProperty("CheckEolTargetFramework", false)
                .SetAssemblyVersion(GitVersion.AssemblySemVer)
                .SetFileVersion(GitVersion.AssemblySemFileVer)
                .SetInformationalVersion(GitVersion.InformationalVersion));
        }
    }

    Target Test => _ => _
        .DependsOn(Compile)
        .Produces(TestResultDirectory / "*.trx")
        .Executes(() => ExecutesTest(false));

    void ExecutesTest(bool excludeNetFramework)
    {
        Logger.Info(excludeNetFramework ? "Exclude net framework" : "Include net framework");

        var testConfigurations =
            from project in TestProjects
            from framework in project.GetTargetFrameworksForTest(excludeNetFramework)
            select new {project, framework};

        DotNetTest(_ =>
            {
                return _
                    .SetConfiguration(Configuration)
                    .SetNoRestore(InvokedTargets.Contains(Restore))
                    .SetNoBuild(InvokedTargets.Contains(Compile))
                    .ResetVerbosity()
                    .AddProperty("CheckEolTargetFramework", false)
                    .SetResultsDirectory(TestResultDirectory)
                    .CombineWith(testConfigurations, (_, v) => _
                        .SetProjectFile(v.project)
                        .SetFramework(v.framework)
                        .SetLogger($"trx;LogFileName={v.project.Name}-{v.framework}.trx"));
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
                .Any(x => !x.Contains("standard") || !x.Contains("core"));
            ExecutesCompile(excludeNetFramework);
        });

    Target TestCoreOnly => _ => _
        .DependsOn(CompileCoreOnly)
        .Produces(TestResultDirectory / "*.trx")
        .Executes(() =>
        {
            var excludeNetFramework = AllProjects.SelectMany(x => x.GetTargetFrameworks()).Distinct()
                .Any(x => !x.Contains("standard") || !x.Contains("core"));
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