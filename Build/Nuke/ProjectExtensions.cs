using System.Collections.Generic;
using System.Linq;
using Nuke.Common.ProjectModel;

public static class ProjectExtensions
{
    public static IReadOnlyCollection<string> GetTargetFrameworks(this Project project, bool excludeNetFramework)
    {
        var frameworks = project.GetTargetFrameworks();
        if (!excludeNetFramework)
            return frameworks;
        return frameworks.Where(x => x.Contains("standard") || x.Contains("core")).ToList();
    }
}