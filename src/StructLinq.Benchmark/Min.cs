using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser, DisassemblyDiagnoser(4)]
    public class Min
    {
        private const int Count = 10000;

        [Benchmark(Baseline = true)]
        public int RawMin()
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
            return Enumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int StructMin()
        {
            return StructEnumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int ZeroAllocStructMin()
        {
            return StructEnumerable.Range(0, Count).Min(x=>x);
        }


        [Benchmark]
        public int ConvertMin()
        {
            return Enumerable.Range(0, Count).ToStructEnumerable().Min();
        }

    }
}