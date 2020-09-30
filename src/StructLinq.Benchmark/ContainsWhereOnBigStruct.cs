using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ContainsWhereOnBigStruct
    {
        private const int Count = 10_000;
        private readonly StructContainer[] array;
        private readonly IEnumerable<StructContainer> enumerable;
        
        public ContainsWhereOnBigStruct()
        {
            array = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
            enumerable = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
        }

        [Benchmark(Baseline = true)]
        public bool Linq()
        {
            return enumerable.Where(x=> true).Contains(StructContainer.Create(5_000));
        }

        [Benchmark]
        public bool Array()
        {
            return array.Where(x=> true).Contains(StructContainer.Create(5_000));
        }

        [Benchmark]
        public bool StructLinq()
        {
            return array.ToStructEnumerable().Where(x=> true, x=>x).Contains(StructContainer.Create(5_000), x=>x);

        }

        [Benchmark]
        public bool RefStructLinq()
        {
            return array.ToRefStructEnumerable().Where((in StructContainer x)=> true, x=>x).Contains(StructContainer.Create(5_000), x=> x);
        }

        [Benchmark]
        public bool StructLinqWithCustomComparer()
        {
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            return array.ToStructEnumerable().Where(x=> true, x=>x).Contains(StructContainer.Create(5_000), comparer, x=>x);

        }

        [Benchmark]
        public bool RefStructLinqZeroAllocwithCustomComparer()
        {
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            return array.ToRefStructEnumerable().Where((in StructContainer x)=> true, x=>x).Contains(StructContainer.Create(5_000), comparer, x=> x);
        }
    }
}
