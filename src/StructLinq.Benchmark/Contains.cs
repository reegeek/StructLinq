using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [DisassemblyDiagnoser(recursiveDepth: 4),MemoryDiagnoser]
    public class Contains
    {
        private const int Count = 10_000;
        private readonly int[] array;
        private readonly IEnumerable<int> enumerable;

        
        public Contains()
        {
            array = Enumerable.Range(0, Count).ToArray();
            enumerable = Enumerable.Range(0, Count).ToArray();
        }

        //[Benchmark(Baseline = true)]
        //public bool Linq()
        //{
        //    return enumerable.Contains(5_000);
        //}

        [Benchmark(Baseline = true)]
        public bool Array()
        {
            return array.Contains(5_000);
        }

        //[Benchmark]
        //public bool StructLinq()
        //{
        //    return array.ToStructEnumerable().Contains(5_000);
        //}

        [Benchmark]
        public bool StructLinqZeroAlloc()
        {
            return array.ToStructEnumerable().Contains(5_000, x=> x);
        }

        [Benchmark]
        public bool WithVisit()
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<DefaultStructEqualityComparer>(ref comparer, 5_000);
            array.ToStructEnumerable().Visit(ref visitor);
            return visitor.contains;
        }

    }

    public struct ContainsVisitor<TComparer> : IVisitor<int>
        where TComparer : IEqualityComparer<int>
    {
        private readonly TComparer comparer;
        private readonly int value;
        public bool contains;
        public ContainsVisitor(ref TComparer comparer, int value)
        {
            this.comparer = comparer;
            this.value = value;
            contains = false;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(int input)
        {
            if (comparer.Equals(input, value))
            {
                contains = true;
                return false;
            }

            return true;
        }
    }
}
