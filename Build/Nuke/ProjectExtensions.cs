using System.Collections.Generic;
using System.Linq;
using Nuke.Common.ProjectModel;

public static class ProjectExtensions
{
    public static IReadOnlyCollection<string> GetTargetFrameworks(this Project project, bool excludeNetFramework)
    {
        var frameworks = project
            .GetTargetFrameworks()
            //because github actions and azure pipeline does not handle it.
            .Where(x=> !(x.Contains("netcoreapp1") || x.Contains("netcoreapp2.2")));
        if (!excludeNetFramework)
            return frameworks.ToList();
        return frameworks.Where(x => x.Contains("standard") || x.Contains("core")).ToList();
    }
}