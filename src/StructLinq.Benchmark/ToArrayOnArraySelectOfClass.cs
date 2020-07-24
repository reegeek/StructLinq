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
    //|           Method |     Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|----------------- |---------:|---------:|---------:|------:|--------:|-------:|-------:|------:|----------:|
    //|             Linq | 27.28 us | 0.515 us | 0.573 us |  1.00 |    0.00 | 9.5215 | 1.1902 |     - |  39.13 KB |
    //|       StructLinq | 47.73 us | 0.781 us | 0.730 us |  1.75 |    0.04 | 9.5215 | 1.1597 |     - |  39.12 KB |
    //| StructLinqFaster | 33.77 us | 0.662 us | 1.177 us |  1.26 |    0.05 | 9.5215 | 1.1597 |     - |  39.09 KB |


    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
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
        public int[] StructLinqFaster()
        {
            var select = new ContainerSelect();
            return array
                   .ToStructEnumerable()
                   .Select(ref @select, x=>x, x=>x)
                   .ToArray(x=>x);
        }
    }
}
