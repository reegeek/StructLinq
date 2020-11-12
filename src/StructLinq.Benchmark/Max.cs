using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser, DisassemblyDiagnoser( 4)]
    public class Max
    {
        private const int Count = 10000;

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
        public int SysMax()
        {
            return Enumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int StructMax()
        {
            return StructEnumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int ZeroAllocStructMax()
        {
            return StructEnumerable.Range(0, Count).Min(x=>x);
        }


        [Benchmark]
        public int ConvertMax()
        {
            return Enumerable.Range(0, Count).ToStructEnumerable().Min();
        }

    }
}