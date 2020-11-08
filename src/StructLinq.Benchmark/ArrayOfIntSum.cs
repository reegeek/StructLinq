using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using Enumerable = System.Linq.Enumerable;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayOfIntSum
    {
        private readonly IEnumerable<int> sysArray;
        private readonly int Count = 1_000;
        private readonly int[] array;
        public ArrayOfIntSum()
        {
            sysArray = Enumerable.ToArray(Enumerable.Range(0,Count));
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
        }
        [Benchmark(Baseline = true)]
        public int Handmaded()
        {
            int sum = 0;
            foreach (var i in array)
            {
                sum += array[i];
            }
            return sum;
        }
        [Benchmark]
        public int LINQ() => sysArray.Sum();

        [Benchmark]
        public int StructLinq() => array.ToStructEnumerable().Sum(x=>x);

    }
}