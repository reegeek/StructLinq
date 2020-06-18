using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Distinct
    {
        private const int Count = 10_000;
        private readonly int[] array;
        
        public Distinct()
        {
            var tmp = Enumerable.Range(0, Count).ToArray();
            var list = new List<int>(tmp);
            list.AddRange(tmp);
            array = list.ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Distinct())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Distinct(x=>x))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ZeroAllocStructLinq()
        {
            var sum = 0;
            var comparer = new StructEqualityComparer();
            foreach (var i in array.ToStructEnumerable().Distinct(comparer, x=>x))
            {
                sum += i;
            }
            return sum;
        }
        
        [Benchmark]
        public int ZeroAllocStructLinqSum()
        {
            var comparer = new StructEqualityComparer();
            return array.ToStructEnumerable().Distinct(comparer, x => x).Sum(x=>x);
        }


        public readonly struct StructEqualityComparer : IEqualityComparer<int>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(int x, int y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(int value) => value.GetHashCode();
        }
    }
}