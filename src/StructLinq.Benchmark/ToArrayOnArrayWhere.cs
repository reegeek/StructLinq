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
    //|             Linq | 33.29 us | 0.346 us | 0.324 us | 33.27 us |  1.00 |    0.00 | 12.6953 | 0.0610 |     - |  52.19 KB |
    //|       StructLinq | 44.34 us | 0.645 us | 0.572 us | 44.20 us |  1.33 |    0.02 |  4.7607 |      - |     - |  19.62 KB |
    //| StructLinqFaster | 26.38 us | 0.524 us | 1.194 us | 25.78 us |  0.82 |    0.05 |  4.7607 |      - |     - |  19.55 KB |
    
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
                   .ToArray(x=>x);
        }
    }
}
