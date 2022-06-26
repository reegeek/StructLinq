using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using StructLinq.Range;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Aggregate
    {
        private readonly StructCollection<int, RangeEnumerable, RangeEnumerator> _rangeEnumerable;
        private readonly IEnumerable<int> _enumerable;
        private const int Count = 10000;
        public Aggregate()
        {
            _rangeEnumerable = StructEnumerable.Range(0, Count);
            _enumerable = Enumerable.Range(0, Count);
        }

        [Benchmark(Baseline = true)]
        public int SysAggregate()
        {
            return _enumerable.Aggregate(0, (accu, elt) => accu + elt);
        }

        [Benchmark]
        public int DelegateAggregate()
        {
            return _rangeEnumerable.Aggregate(0, (accu, elt) => accu + elt);
        }

        [Benchmark]
        public int StructAggregate()
        {
            var aggregation = new Aggregation();
            return _rangeEnumerable.Aggregate(0, ref aggregation);
        }

        [Benchmark]
        public int ZeroAllocStructAggregate()
        {
            var aggregation = new Aggregation();
            return _rangeEnumerable.Aggregate(0, ref aggregation, x=> x);
        }


        [Benchmark]
        public int ConvertAggregate()
        {
            var aggregation = new Aggregation();
            return _enumerable.ToStructEnumerable().Aggregate(0, ref aggregation);
        }
    }

    struct Aggregation : IAggregation<int, int>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Aggregate(int element)
        {
            Result = Result + element;
        }
        public int Result { get; set; }
    }


}