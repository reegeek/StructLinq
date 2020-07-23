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
    //|              Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
    //|                Linq | 21.60 us | 0.256 us | 0.240 us |     - |     - |     - |      48 B |
    //|          StructLinq | 15.13 us | 0.124 us | 0.116 us |     - |     - |     - |      32 B |
    //| StructLinqZeroAlloc | 13.82 us | 0.057 us | 0.053 us |     - |     - |     - |         - |


    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
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
        public int[] StructLinqFaster()
        {
            var select = new SelectFunction();
            return array
                   .ToStructEnumerable()
                   .Select(ref select, x=>x, x=>x)
                   .ToArray(x=>x);
        }
    }
}
