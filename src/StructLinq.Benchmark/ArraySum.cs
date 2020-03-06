using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.IEnumerable;
using Enumerable = System.Linq.Enumerable;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArraySum
    {
        private readonly IEnumerable<int> sysArray;
        private readonly int Count = 1000;
        private readonly int[] array;
        private readonly IStructEnumerable<int, ArrayStructEnumerator<int>> safeStructArray;
        private readonly IStructEnumerable<int, GenericEnumerator<int>> convertArray;
        public ArraySum()
        {
            sysArray = Enumerable.ToArray(Enumerable.Range(0,Count));
            convertArray = sysArray.ToStructEnumerable();
            safeStructArray = Enumerable.ToArray(Enumerable.Range(0, Count)).ToStructEnumerable();
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
        public int ConvertSum() => convertArray.Sum();

        [Benchmark]
        public int SafeStructSum() => safeStructArray.Sum();
    }
}