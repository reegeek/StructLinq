using System.Linq;
using System.Runtime.CompilerServices;
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
        public Container[] StructLinqZeroAlloc() => array
                                           .ToStructEnumerable()
                                           .Where(x => (x.Element & 1) == 0, x=>x)
                                           .ToArray(x=>x);

        [Benchmark]
        public Container[] StructLinqWithFunction()
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Eval(Container element)
        {
            return (element.Element & 1) == 0;
        }
    }
}
