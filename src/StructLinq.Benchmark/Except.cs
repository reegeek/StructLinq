﻿using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Except
    {
        private const int Count = 10000;
        private int[] array1;
        private int[] array2;

        public Except()
        {
            var size1 = Count / 2;
            var size2 = Count - size1;
            array1 = Enumerable.Range(0, size1).ToArray();
            array2 = Enumerable.Range(size1 - 100, size2).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array1.Except(array2))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array1.ToStructEnumerable().Except(array2.ToStructEnumerable()))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var sum = 0;
            foreach (var i in array1.ToStructEnumerable().Except(array2.ToStructEnumerable(), x => x, x => x))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAllocAndComparer()
        {
            var sum = 0;
            var comparer = new DefaultStructEqualityComparer();
            foreach (var i in array1.ToStructEnumerable().Except(array2.ToStructEnumerable(), comparer, x => x, x => x))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAllocAndComparerSum()
        {
            var comparer = new DefaultStructEqualityComparer();
            return array1.ToStructEnumerable()
                         .Except(array2.ToStructEnumerable(), comparer, x => x, x => x)
                         .Sum(x=>x);
        }

    }
}