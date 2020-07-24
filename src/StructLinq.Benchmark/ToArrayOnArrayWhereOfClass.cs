using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.302
    //[Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


    //```
    //|           Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|----------------- |---------:|---------:|---------:|---------:|------:|--------:|--------:|-------:|------:|----------:|
    //|             Linq | 71.07 us | 1.608 us | 4.742 us | 69.44 us |  1.00 |    0.00 | 25.2686 | 6.2256 |     - | 103.73 KB |
    //|       StructLinq | 64.15 us | 1.268 us | 1.509 us | 63.67 us |  0.82 |    0.03 |  9.5215 | 1.0986 |     - |  39.15 KB |
    //| StructLinqFaster | 42.11 us | 0.831 us | 1.752 us | 41.63 us |  0.57 |    0.04 |  9.5215 | 1.1597 |     - |  39.09 KB |

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
