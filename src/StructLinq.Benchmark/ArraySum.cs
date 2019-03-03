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
        public int Count = 1000;
        private readonly ITypedEnumerable<int, UnmanagedArrayEnumerator<int>> structArray;
        private readonly int[] array;
        private readonly ITypedEnumerable<int, ArrayStructEnumerator<int>> safeStructArray;
        private ITypedEnumerable<int, GenericEnumerator<int>> convertArray;
        public ArraySum()
        {
            sysArray = Enumerable.ToArray(Enumerable.Range(0,Count));
            structArray = Enumerable.ToArray(Enumerable.Range(0, Count)).ToTypedEnumerable();
            convertArray = sysArray.ToTypedEnumerable();
            safeStructArray = Enumerable.ToArray(Enumerable.Range(0, Count)).SafeToTypedEnumerable();
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
        }
        [Benchmark]
        public int SysSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
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
        public int StructSum() => structArray.Sum();

        [Benchmark]
        public int SafeStructSum() => safeStructArray.Sum();
    }
}