using System.Collections.Generic;
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
    //|           Method |     Mean |    Error |   StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|----------------- |---------:|---------:|---------:|------:|--------:|--------:|-------:|------:|----------:|
    //|             Linq | 38.64 us | 0.849 us | 0.794 us |  1.00 |    0.00 | 15.6860 | 0.1221 |     - |  64.34 KB |
    //|       StructLinq | 48.93 us | 0.849 us | 0.794 us |  1.27 |    0.04 |  4.7607 |      - |     - |  19.65 KB |
    //| StructLinqFaster | 26.22 us | 0.502 us | 0.493 us |  0.68 |    0.02 |  4.7607 |      - |     - |  19.59 KB |

    [MemoryDiagnoser]
    public class ToListOnArrayWhere
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ToListOnArrayWhere()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public List<int> Linq() => array
                                   .Where(x => (x & 1) == 0)
                                   .ToList();


        [Benchmark]
        public List<int> StructLinq() => array
                                         .ToStructEnumerable()
                                         .Where(x => (x & 1) == 0)
                                         .ToList();

        [Benchmark]
        public List<int> StructLinqFaster()
        {
            var where = new WherePredicate();
            return array
                   .ToStructEnumerable()
                   .Where(ref where, x=> x)
                   .ToList(x=> x);
        }
    }
}
