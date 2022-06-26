using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ToArrayOnArraySelect
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ToArrayOnArraySelect()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int[] Linq() => array
                               .Select(x => x * 2)
                               .ToArray();


        [Benchmark]
        public int[] StructLinq() => array
                                     .ToStructEnumerable()
                                     .Select(x => x * 2)
                                     .ToArray();

        
        [Benchmark]
        public int[] StructLinqZeroAlloc() => array
                                     .ToStructEnumerable()
                                     .Select(x => x * 2)
                                     .ToArray(x=>x);

        [Benchmark]
        public int[] StructLinqWithFunction()
        {
            var select = new SelectFunction();
            return array
                   .ToStructEnumerable()
                   .Select(ref @select, x=>x, x=>x)
                   .ToArray(x=>x);
        }

    }
}
