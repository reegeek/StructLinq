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
    //|             Linq | 20.16 us | 0.074 us | 0.069 us |  1.00 | 9.5215 | 1.1902 |     - |  39.13 KB |
    //|       StructLinq | 34.34 us | 0.129 us | 0.115 us |  1.70 | 9.5215 | 1.1597 |     - |  39.12 KB |
    //| StructLinqFaster | 19.52 us | 0.158 us | 0.140 us |  0.97 | 9.5215 | 1.1902 |     - |  39.09 KB |

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
