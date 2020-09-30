using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ToArrayOnArrayWhereOfClass
    {
        private const int Count = 10000;
        private readonly Container[] array;

        public ToArrayOnArrayWhereOfClass()
        {
            array = Enumerable.Range(0, Count).Select(x=> new Container(x)).ToArray();
        }

        [Benchmark(Baseline = true)]
        public Container[] Linq() => array
                                     .Where(x => (x.Element & 1) == 0)
                                     .ToArray();


        [Benchmark]
        public Container[] StructLinq() => array
                                           .ToStructEnumerable()
                                           .Where(x => (x.Element & 1) == 0)
                                           .ToArray();

        [Benchmark]
        public Container[] StructLinqFaster()
        {
            var where = new WhereContainerPredicate();
            return array
                   .ToStructEnumerable()
                   .Where(ref where, x=> x)
                   .ToArray(x=>x);
        }
    }

    public readonly struct WhereContainerPredicate : IFunction<Container, bool>
    {
        public bool Eval(Container element)
        {
            return (element.Element & 1) == 0;
        }
    }
}
