using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Nuke.Common.ProjectModel;

public static class ProjectExtensions
{
    public static IReadOnlyCollection<string> GetTargetFrameworks(this Project project, bool excludeNetFramework)
    {
        var frameworks = project.GetTargetFrameworks();
        if (!excludeNetFramework)
            return frameworks.ToList();
        return frameworks.Where(x => x.Contains("standard") || x.Contains("core") || x.Contains("net50")).ToList();
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

    public static IEnumerable<(Project project, string framework, string platform)> Filter(this IEnumerable<(Project project, string framework, string platform)> list, bool isLocal)
    {
        if (isLocal)
            return list;
        //exclude netcore 2.1 and 2.2 in x86 because is not well handle by azure pipelines and github actions on windows
        return list.Where(x =>
        {
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

}