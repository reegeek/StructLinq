using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Range;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser]
    public class Min
    {
        private const int Count = 10000;

        [Benchmark(Baseline = true)]
        public int Handmaded()
        {
            var min = int.MaxValue;
            for (var index = 0; index < Count; index++)
            {
                if (index < min)
                    min = index;
            }

            return min;
        } 

        [Benchmark]
        public int LINQ()
        {
            return Enumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int StructLINQ()
        {
            return StructEnumerable.Range(0, Count).Min();
        }


        [Benchmark]
        public int ZeroAllocStructLINQ()
        {
            return StructEnumerable.Range(0, Count).Min(x=> (IStructEnumerable<int, RangeEnumerator>)x);
        }


        [Benchmark]
        public int ZeroAllocStructLINQOnCollection()
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