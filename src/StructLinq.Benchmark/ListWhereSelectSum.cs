using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser]
    public class ListWhereSelectSum
    {
        private const int Count = 10000;
        private readonly List<int> list;

        public ListWhereSelectSum()
        {
            list = Enumerable.Range(0, Count).ToList();
        }

      
        [Benchmark(Baseline = true)]
        public int LINQ() => list
                             .Where(x => (x & 1) == 0)
                             .Select(x => x * 2)
                             .Sum();

        [Benchmark]
        public int StructLinqWithDelegate()
            => list
               .ToStructEnumerable()
               .Where(x => (x & 1) == 0)
               .Select(x => x * 2)
               .Sum();

        [Benchmark]
        public int StructLinqWithDelegateZeroAlloc()
            => list
               .ToStructEnumerable()
               .Where(x => (x & 1) == 0, x=>x)
               .Select(x => x * 2, x=>x)
               .Sum(x=>x);

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            return list
                   .ToStructEnumerable()
                   .Where(ref @where, x => x)
                   .Select(ref @select, x => x, x => x)
                   .Sum(x => x);
        }
    }
}
