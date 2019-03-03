using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.IEnumerable;
using StructLinq.Range;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Min
    {
        private readonly IEnumerable<int> sysRange;
        private readonly ITypedEnumerable<int, GenericEnumerator<int>> convertRange;
        public int Count = 10000;
        private ITypedEnumerable<int, RangeEnumerator> structRange;
        public Min()
        {
            sysRange = Enumerable.Range(0, Count);
            convertRange = Enumerable.Range(0, Count).ToTypedEnumerable();
            structRange = StructEnumerable.Range(0, Count);
        }


        [Benchmark(Baseline = true)]
        public int SysMin()
        {
            return sysRange.Min();
        }

        [Benchmark]
        public int StructMin()
        {
            return structRange.Min();
        }

        [Benchmark]
        public int ConvertMin()
        {
            return convertRange.Min();
        }

    }
}