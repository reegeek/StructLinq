using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Range;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser, DisassemblyDiagnoser(4)]
    public class Max
    {
        private const int Count = 10000;

        [Benchmark(Baseline = true)]
        public int Handmaded()
        {
            var max = int.MinValue;
            for (var index = 0; index < Count; index++)
            {
                if (index > max)
                    max = index;
            }

            return max;
        } 

        [Benchmark]
        public int LINQ()
        {
            return Enumerable.Range(0, Count).Max();
        }

        [Benchmark]
        public int StructLINQ()
        {
            return StructEnumerable.Range(0, Count).Max();
        }


        [Benchmark]
        public int ZeroAllocStructLINQ()
        {
            return StructEnumerable.Range(0, Count).Max(x=> x);
        }


        [Benchmark]
        public int ZeroAllocStructLINQOnEnumerable()
        {
            return StructEnumerable.Range(0, Count).Max(x=>(IStructEnumerable<int, RangeEnumerator>)x);
        }


        [Benchmark]
        public int ConvertMin()
        {
            return Enumerable.Range(0, Count).ToStructEnumerable().Max();
        }

    }
}