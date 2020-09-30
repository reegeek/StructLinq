using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
   
    [MemoryDiagnoser]
    public class DistinctOnBigStruct
    {
        private const int Count = 10_000;
        private readonly StructContainer[] array;
        
        public DistinctOnBigStruct()
        {
            var tmp = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
            var list = new List<StructContainer>(tmp);
            list.AddRange(tmp);
            array = list.ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            var structEqualityComparer = new StructEqualityComparer();
            foreach (var i in array.Distinct(structEqualityComparer))
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            var comparer = new StructEqualityComparer();
            foreach (var i in array.ToStructEnumerable().Distinct(comparer, x=>x))
            {
                sum += i.Element;
            }
            return sum;
        }
        
        [Benchmark]
        public int RefStructLinqSum()
        {
            var sum = 0;
            var comparer = new StructEqualityComparer();
            foreach (var i in array.ToRefStructEnumerable().Distinct(comparer, x=>x))
            {
                sum += i.Element;
            }
            return sum;
        }


        internal readonly struct StructEqualityComparer : IEqualityComparer<StructContainer>, IInEqualityComparer<StructContainer>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(StructContainer x, StructContainer y)
            {
                return x.Element == y.Element;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(StructContainer obj)
            {
                return obj.Element.GetHashCode();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in StructContainer x, in StructContainer y)
            {
                return x.Element == y.Element;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in StructContainer obj)
            {
                return obj.Element.GetHashCode();
            }

        }
    }
}
