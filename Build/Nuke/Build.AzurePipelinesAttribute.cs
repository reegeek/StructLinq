using System;
using System.Collections.Generic;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI.AzurePipelines;
using Nuke.Common.CI.AzurePipelines.Configuration;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;

partial class Build
{
    public class AzurePipelinesAttribute : Nuke.Common.CI.AzurePipelines.AzurePipelinesAttribute
    {
        public AzurePipelinesAttribute(
            string suffix,
            AzurePipelinesImage image,
            params AzurePipelinesImage[] images)
            : base(suffix, image, images)
        {
        }

        protected override AzurePipelinesStage GetStage(AzurePipelinesImage image, IReadOnlyCollection<ExecutableTarget> relevantTargets)
        {
            string[] targetToExcludes;
            switch (image)
            {
                case AzurePipelinesImage.WindowsLatest:
                case AzurePipelinesImage.Windows2019:
                case AzurePipelinesImage.Vs2017Win2016:
                case AzurePipelinesImage.Vs2015Win2012R2:
                case AzurePipelinesImage.Win1803:
                    targetToExcludes = new []{ nameof(TestCoreOnly), nameof(CompileCoreOnly), nameof(PackCoreOnly)};
                    break;
                case AzurePipelinesImage.Ubuntu1604:
                case AzurePipelinesImage.Ubuntu1804:
                case AzurePipelinesImage.UbuntuLatest:
                case AzurePipelinesImage.MacOsLatest:
                case AzurePipelinesImage.MacOs1014:
                case AzurePipelinesImage.MacOs1013:
                    targetToExcludes = new[] { nameof(Test), nameof(Compile), nameof(Pack) };
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(image), image, null);
            }

            var filterRelevantTargets = relevantTargets.Where(x => !targetToExcludes.Contains(x.Name)).ToList();

            return base.GetStage(image, filterRelevantTargets);
        }

        protected override AzurePipelinesJob GetJob(ExecutableTarget executableTarget,
            LookupTable<ExecutableTarget, AzurePipelinesJob> jobs)
        {
            var job = base.GetJob(executableTarget, jobs);

            var dictionary = new Dictionary<string, string>
            {
                {nameof(Compile), "⚙️"},
                {nameof(CompileCoreOnly), "⚙️"},
                {nameof(Test), "🚦"},
                {nameof(TestCoreOnly), "🚦"},
                {nameof(Pack), "📦"},
                {nameof(PackCoreOnly), "📦"},
            };
            var symbol = dictionary.GetValueOrDefault(job.Name);
            var prefix = symbol == null ? "" : $"{symbol} ";
            job.DisplayName = job.PartitionName == null
                ? $"{prefix}{job.DisplayName}"
                : $"{prefix}{job.DisplayName} 🧩";
            return job;
        }
    }
}