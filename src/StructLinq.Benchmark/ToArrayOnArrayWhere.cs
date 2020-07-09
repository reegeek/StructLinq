using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.301
    //[Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


    //```
    //|           Method |     Mean |    Error |   StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|----------------- |---------:|---------:|---------:|------:|--------:|--------:|-------:|------:|----------:|
    //|             Linq | 36.78 us | 0.672 us | 0.596 us |  1.00 |    0.00 | 12.6953 | 0.0610 |     - |  52.19 KB |
    //|       StructLinq | 48.10 us | 0.786 us | 0.735 us |  1.31 |    0.03 | 20.3857 | 0.0610 |     - |  83.91 KB |
    //| StructLinqFaster | 31.74 us | 0.508 us | 0.475 us |  0.86 |    0.02 | 20.3857 | 0.0610 |     - |  83.89 KB |


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
        public int[] StructLinqFaster()
        {
            var where = new WherePredicate();
            return array
                   .ToStructEnumerable()
                   .Where(ref where, x=> x)
                   .ToArray();
        }
    }
}
