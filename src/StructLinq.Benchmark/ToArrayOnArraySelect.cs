using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.401
    //[Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


    //```
    //|           Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|----------------- |---------:|---------:|---------:|------:|-------:|-------:|------:|----------:|
    //|             Linq | 19.66 us | 0.104 us | 0.087 us |  1.00 | 9.5215 | 0.0305 |     - |  39.13 KB |
    //|       StructLinq | 35.00 us | 0.147 us | 0.130 us |  1.78 | 9.5215 | 0.0610 |     - |  39.12 KB |
    //| StructLinqFaster | 20.81 us | 0.065 us | 0.057 us |  1.06 | 9.5215 | 0.0305 |     - |  39.09 KB |

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
                   .Select(ref @select, x=>x, x=>x)
                   .ToArray(x=>x);
        }
    }
}
