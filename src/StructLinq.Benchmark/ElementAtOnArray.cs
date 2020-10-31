using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ElementAtOnArray
    {
        private const int Count = 1000;
        private readonly int[] array;
        private readonly IEnumerable<int> enumerable;
        public ElementAtOnArray()
        {
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
            enumerable = Enumerable.ToArray(Enumerable.Range(0, Count));
        }

        [Benchmark(Baseline = true)]
        public int Linq() => array.ElementAt(Count / 2);

        [Benchmark]
        public int EnumerableLinq() => enumerable.ElementAt(Count / 2);


        [Benchmark]
        public int StructLinq() => array.ToStructEnumerable().ElementAt(Count / 2);

        [Benchmark]
        public int StructLinqZeroAlloc() => array.ToStructEnumerable().ElementAt(Count / 2, x=>x);

        [Benchmark]
        public int StructLinqZeroAllocWithEnumerator() => array.ToStructEnumerable().ElementAt(Count / 2, x => (IStructEnumerable<int, ArrayStructEnumerator<int>>)x);


    }
}
