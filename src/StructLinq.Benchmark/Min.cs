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
        private readonly IStructEnumerable<int, GenericEnumerator<int>> convertRange;
        private const int Count = 10000;
        private readonly IStructEnumerable<int, RangeEnumerator> structRange;
        public Min()
        {
            sysRange = Enumerable.Range(0, Count);
            convertRange = Enumerable.Range(0, Count).ToStructEnumerable();
            structRange = StructEnumerable.Range(0, Count);
        }

        [Benchmark(Baseline = true)]
        public int RawMax()
        {
            var max = int.MaxValue;
            for (var index = 0; index < Count; index++)
            {
                if (index < max)
                    max = index;
            }

            return max;
        } 

        [Benchmark]
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