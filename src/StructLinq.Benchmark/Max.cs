using System;
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
        private const int Count = 10000;
        private readonly ITypedEnumerable<int, RangeEnumerator> structRange;
        public Max()
        {
            sysRange = Enumerable.Range(0, Count);
            convertRange = Enumerable.Range(0, Count).ToTypedEnumerable();
            structRange = StructEnumerable.Range(0, Count);
        }

        [Benchmark(Baseline = true)]
        public int RawMax()
        {
            int max = int.MinValue;
            for (int index = 0; index < Count; index++)
            {
                if (index > max)
                    max = index;
            }

            return max;
        }

        [Benchmark]
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