using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Nuke.Common.CI.AzurePipelines;
using Nuke.Common.ProjectModel;

public static class ProjectExtensions
{
    public static IReadOnlyCollection<string> GetTargetFrameworks(this Project project, bool excludeNetFramework)
    {
        var frameworks = project.GetTargetFrameworks();
        if (!excludeNetFramework)
            return frameworks.ToList();
        return frameworks.Where(x => x.Contains("standard") || x.Contains("core") || x.Contains("net50")  || x.Contains("net60")).ToList();
    }

    public static IReadOnlyCollection<string> GetPlatforms(this Project project)
    {
        var msbuildProject = project.GetMSBuildProject();
        var targetFrameworkProperty = msbuildProject.GetProperty("Platform");
        if (targetFrameworkProperty != null)
            return new[] { targetFrameworkProperty.EvaluatedValue };

        var targetFrameworksProperty = msbuildProject.GetProperty("Platforms");
        if (targetFrameworksProperty != null)
            return targetFrameworksProperty.EvaluatedValue.Split(';');

        return new string[0];
    }

    public static IReadOnlyCollection<string> GetPlatformsForTests(this Project project)
    {

        var isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        var platforms = project.GetPlatforms();
        if (isWindows)
            return platforms;
        return platforms.Where(x=> x != "x86").ToList();
    }

    public static IEnumerable<(Project project, string framework, string platform)> Filter(
        this IEnumerable<(Project project, string framework, string platform)> list, bool isLocal,
        AzurePipelines azurePipelines)
    {
        if (isLocal)
            return list;
        return list.Where(x =>
        {
            // exclude netcore 2.2 for azure pipelines
            if (azurePipelines != null && x.framework.Contains("2.2"))
                return false;

            //exclude netcore 2.1 and 2.2 in x86 because is not well handle by azure pipelines and github actions on windows
            if (x.platform != "x86")
                return true;
            if (x.framework == null)
                return false;
            if (x.framework.Contains("2.1"))
                return false;
            if (x.framework.Contains("2.2"))
                return false;
            return true;
        });
    }


    public static IEnumerable<IEnumerable<(Project project, string framework, string platform)>> Group(
        this IEnumerable<(Project project, string framework, string platform)> list)
    {
        var toList = list.ToList();
        foreach (var element in toList.Where(x=> x.project.Name.Contains("StructLinq.Tests")))
        {
            yield return new[] {element};
        }

        yield return toList.Where(x => !x.project.Name.Contains("StructLinq.Tests"));
    }

}
