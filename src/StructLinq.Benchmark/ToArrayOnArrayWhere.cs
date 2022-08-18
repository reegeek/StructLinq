using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
   
    [MemoryDiagnoser]
    public class ToArrayOnArrayWhere
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ToArrayOnArrayWhere()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int[] Linq() => array
                               .Where(x => (x & 1) == 0)
                               .ToArray();


        [Benchmark]
        public int[] StructLinq() => array
                                     .ToStructEnumerable()
                                     .Where(x => (x & 1) == 0)
                                     .ToArray();

        [Benchmark]
        public int[] StructLinqZeroAlloc() => array
                                     .ToStructEnumerable()
                                     .Where(x => (x & 1) == 0)
                                     .ToArray();

        
        [Benchmark]
        public int[] StructLinqWithFunction()
        {
            var where = new WherePredicate();
            return array
                   .ToStructEnumerable()
                   .Where(ref where)
                   .ToArray();
        }
    }
}
