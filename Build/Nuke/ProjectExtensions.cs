using System.Collections.Generic;
using System.Linq;
using Nuke.Common.ProjectModel;

public static class ProjectExtensions
{
    public static IReadOnlyCollection<string> GetTargetFrameworks(this Project project, bool excludeNetFramework)
    {
        var frameworks = project
            .GetTargetFrameworks()
            .Where(x=> !x.Contains("netcoreapp1"));
        if (!excludeNetFramework)
            return frameworks.ToList();
        return frameworks.Where(x => x.Contains("standard") || x.Contains("core")).ToList();
    }
}