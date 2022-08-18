using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ContainsOnBigStruct
    {
        private const int Count = 10_000;
        private readonly StructContainer[] array;
        private readonly IEnumerable<StructContainer> enumerable;
        
        public ContainsOnBigStruct()
        {
            array = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
            enumerable = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
        }

        [Benchmark(Baseline = true)]
        public bool Linq()
        {
            return enumerable.Contains(StructContainer.Create(5_000));
        }

        [Benchmark]
        public bool Array()
        {
            return array.Contains(StructContainer.Create(5_000));
        }

        [Benchmark]
        public bool StructLinq()
        {
            return array.ToStructEnumerable().Contains(StructContainer.Create(5_000));

        }

        [Benchmark]
        public bool RefStructLinq()
        {
            return array.ToRefStructEnumerable().Contains(StructContainer.Create(5_000), x=> x);
        }

        [Benchmark]
        public bool StructLinqWithCustomComparer()
        {
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            return array.ToStructEnumerable().Contains(StructContainer.Create(5_000), comparer);

        }

        [Benchmark]
        public bool RefStructLinqZeroAllocwithCustomComparer()
        {
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            return array.ToRefStructEnumerable().Contains(StructContainer.Create(5_000), comparer, x=> x);
        }
    }
}
