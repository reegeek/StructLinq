using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Enumerable = System.Linq.Enumerable;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayOfIntSum
    {
        private readonly IEnumerable<int> sysArray;
        private readonly int Count = 1000;
        private readonly int[] array;
        public ArrayOfIntSum()
        {
            sysArray = Enumerable.ToArray(Enumerable.Range(0,Count));
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
        }
        [Benchmark]
        public int SysSum()
        {
            int sum = 0;
            foreach (var i in array)
            {
                sum += array[i];
            }
            return sum;
        }
        [Benchmark(Baseline = true)]
        public int SysEnumerableSum() => Enumerable.Sum(sysArray);

        [Benchmark]
        public int ConvertSum() => sysArray.ToStructEnumerable().Sum(x=>x);

        [Benchmark]
        public int StructSum() => array.ToStructEnumerable().Sum(x=>x);
    }
}