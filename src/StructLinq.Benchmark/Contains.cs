using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.402
    //[Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


    //```
    //|              Method |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
    //|                Linq | 1.409 us | 0.0343 us | 0.1001 us | 1.382 us |  1.00 |    0.00 |      - |     - |     - |         - |
    //|               Array | 1.274 us | 0.0175 us | 0.0163 us | 1.272 us |  0.92 |    0.05 |      - |     - |     - |         - |
    //|          StructLinq | 2.244 us | 0.0353 us | 0.0313 us | 2.240 us |  1.63 |    0.09 | 0.0076 |     - |     - |      40 B |
    //| StructLinqZeroAlloc | 2.924 us | 0.0203 us | 0.0190 us | 2.926 us |  2.11 |    0.12 |      - |     - |     - |         - |

    [DisassemblyDiagnoser(recursiveDepth: 4),MemoryDiagnoser]
    public class Contains
    {
        private const int Count = 10_000;
        private readonly int[] array;
        private readonly IEnumerable<int> enumerable;

        
        public Contains()
        {
            array = Enumerable.Range(0, Count).ToArray();
            enumerable = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public bool Linq()
        {
            return enumerable.Contains(5_000);
        }

        [Benchmark]
        public bool Array()
        {
            return array.Contains(5_000);
        }

        [Benchmark]
        public bool StructLinq()
        {
            return array.ToStructEnumerable().Contains(5_000);
        }

        [Benchmark]
        public bool StructLinqZeroAlloc()
        {
            return array.ToStructEnumerable().Contains(5_000, x=> x);
        }
    }
}
