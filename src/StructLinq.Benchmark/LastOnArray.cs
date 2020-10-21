using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class LastOnArray
    {
        private const int Count = 1000;
        private readonly int[] array;
        private readonly IEnumerable<int> enumerable;
        public LastOnArray()
        {
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
            enumerable = Enumerable.ToArray(Enumerable.Range(0, Count));
        }

        [Benchmark(Baseline = true)]
        public int Linq() => array.Last();

        [Benchmark]
        public int EnumerableLinq() => enumerable.Last();


        [Benchmark]
        public int StructLinq() => array.ToStructEnumerable().Last();

        [Benchmark]
        public int StructLinqZeroAlloc() => array.ToStructEnumerable().Last( x => x);
    }
}