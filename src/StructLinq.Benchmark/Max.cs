using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.IEnumerable;
using StructLinq.Range;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Max
    {
        private readonly IEnumerable<int> sysRange;
        private readonly ITypedEnumerable<int, GenericEnumerator<int>> convertRange;
        public int Count = 10000;
        private ITypedEnumerable<int, RangeEnumerator> structRange;
        public Max()
        {
            sysRange = Enumerable.Range(0, Count);
            convertRange = Enumerable.Range(0, Count).ToTypedEnumerable();
            structRange = StructEnumerable.Range(0, Count);
        }


        [Benchmark(Baseline = true)]
        public int SysMax()
        {
            return sysRange.Max();
        }

        [Benchmark]
        public int StructMax()
        {
            return structRange.Max();
        }

        [Benchmark]
        public int ConvertMax()
        {
            return convertRange.Max();
        }

    }
}