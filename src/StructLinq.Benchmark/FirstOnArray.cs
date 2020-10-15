using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class FirstOnArray
    {
        private const int Count = 1000;
        private readonly int[] array;
        private readonly IEnumerable<int> enumerable;
        public FirstOnArray()
        {
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
            enumerable = Enumerable.ToArray(Enumerable.Range(0, Count));
        }

        [Benchmark(Baseline = true)]
        public int Linq() => array.First();

        [Benchmark]
        public int EnumerableLinq() => enumerable.First();


        [Benchmark]
        public int StructLinq() => array.ToStructEnumerable().First();

        [Benchmark]
        public int StructLinqZeroAlloc() => array.ToStructEnumerable().First(x=>x);

    }
}
