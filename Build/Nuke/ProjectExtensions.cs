using System;
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

}