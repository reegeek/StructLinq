using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ToArrayOnArraySelectOfClass
    {
        private const int Count = 10000;
        private readonly Container[] array;

        public ToArrayOnArraySelectOfClass()
        {
            array = Enumerable.Range(0, Count).Select(x=> new Container(x)).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int[] Linq() => array
                               .Select(x => x.Element)
                               .ToArray();


        [Benchmark]
        public int[] StructLinq() => array
                                     .ToStructEnumerable()
                                     .Select(x => x.Element)
                                     .ToArray();

        [Benchmark]
        public int[] StructLinqZeroAlloc() => array
                                     .ToStructEnumerable()
                                     .Select(x => x.Element, x=> x)
                                     .ToArray(x=>x);

        
        [Benchmark]
        public int[] StructLinqWithFunction()
        {
            var select = new ContainerSelect();
            return array
                   .ToStructEnumerable()
                   .Select(ref @select, x=>x, x=>x)
                   .ToArray(x=>x);
        }
    }
}
