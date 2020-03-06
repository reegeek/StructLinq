using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.IEnumerable;
using StructLinq.Range;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Aggregate
    {
        private readonly IEnumerable<int> sysRange;
        private readonly IStructEnumerable<int, RangeEnumerator> structRange;
        private readonly IStructEnumerable<int, GenericEnumerator<int>> convertRange;
        private readonly Aggregation[] aggregations = new Aggregation[1];
        private const int Count = 10000;
        public Aggregate()
        {
            sysRange = Enumerable.Range(0, Count);
            structRange = StructEnumerable.Range(0, Count);
            convertRange = sysRange.ToStructEnumerable();
        }

        [Benchmark(Baseline = true)]
        public int SysAggregate()
        {
            return sysRange.Aggregate(0, (accu, elt) => accu + elt);
        }

        [Benchmark]
        public int DelegateAggregate()
        {
            return structRange.Aggregate(0, (accu, elt) => accu + elt);
        }

        [Benchmark]
        public int StructAggregate()
        {
            return structRange.Aggregate(0, ref aggregations[0]);
        }

        [Benchmark]
        public int ConvertAggregate()
        {
            return convertRange.Aggregate(0, ref aggregations[0]);
        }
    }

    struct Aggregation : IAggregation<int, int>
    {
        public void Aggregate(int element)
        {
            Result = Result + element;
        }
        public int Result { get; set; }
    }


}