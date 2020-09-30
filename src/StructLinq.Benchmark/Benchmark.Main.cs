using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace StructLinq.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var summary in BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args))
            {
                SaveSummary(summary);
            }
        }

        static void SaveSummary(Summary summary)
        {
            var solutionDir = GetSolutionDirectory();
            if (solutionDir is null)
                return;

            var targetType = GetTargetType(summary);
            if (targetType is null)
                return;

            var title = targetType.Name;

            var resultsPath = Path.Combine(solutionDir, "Documents/BenchmarksResults");
            _ = Directory.CreateDirectory(resultsPath);

            var filePath = Path.Combine(resultsPath, $"{title}.md");

            if (File.Exists(filePath))
                File.Delete(filePath);

            using var fileWriter = new StreamWriter(filePath, false, Encoding.UTF8);
            var logger = new StreamLogger(fileWriter);

            logger.WriteLine($"## {title}");
            logger.WriteLine();

            logger.WriteLine("### Source");
            var sourceLink = new StringBuilder("../../src/StructLinq.Benchmark");
            _ = sourceLink.Append($"/{targetType.Name}.cs");
            logger.WriteLine($"[{targetType.Name}.cs]({sourceLink})");

            logger.WriteLine();

            logger.WriteLine("### Results:");
            MarkdownExporter.GitHub.ExportToLog(summary, logger);
        }


        static Type GetTargetType(Summary summary)
        {
            var targetTypes = summary.BenchmarksCases.Select(i => i.Descriptor.Type).Distinct().ToList();
            return targetTypes.Count == 1 ? targetTypes[0] : null;
        }

        static string GetSolutionDirectory()
        {
            var dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            while (!string.IsNullOrEmpty(dir))
            {
                if (Directory.EnumerateFiles(dir, "*.sln", SearchOption.TopDirectoryOnly).Any())
                    return dir;

                dir = Path.GetDirectoryName(dir);
            }

            return null;
        }
    }
}
