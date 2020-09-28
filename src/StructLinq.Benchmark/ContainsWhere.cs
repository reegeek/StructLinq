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
    //|              Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
    //|                Linq | 32.64 us | 0.638 us | 0.566 us |  1.00 |    0.00 |     - |     - |     - |      48 B |
    //|               Array | 32.22 us | 0.400 us | 0.355 us |  0.99 |    0.02 |     - |     - |     - |      48 B |
    //|          StructLinq | 18.95 us | 0.172 us | 0.152 us |  0.58 |    0.01 |     - |     - |     - |      72 B |
    //| StructLinqZeroAlloc | 19.46 us | 0.607 us | 0.596 us |  0.60 |    0.02 |     - |     - |     - |         - |


    [DisassemblyDiagnoser(recursiveDepth: 4),MemoryDiagnoser]
    public class ContainsWhere
    {
        private const int Count = 10_000;
        private readonly int[] array;
        private readonly IEnumerable<int> enumerable;

        
        public ContainsWhere()
        {
            array = Enumerable.Range(0, Count).ToArray();
            enumerable = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public bool Linq()
        {
            return enumerable.Where(x=> true).Contains(5_000);
        }

        [Benchmark]
        public bool Array()
        {
            return array.Where(x=> true).Contains(5_000);
        }

        [Benchmark]
        public bool StructLinq()
        {
            return array.ToStructEnumerable().Where(x=> true).Contains(5_000);
        }

        [Benchmark]
        public bool StructLinqZeroAlloc()
        {
            return array.ToStructEnumerable().Where(x=> true, x=> x).Contains(5_000, x=> x);
        }
    }
}
