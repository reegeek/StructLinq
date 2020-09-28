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
    //|                                   Method |      Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------------------------------- |----------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
    //|                                     Linq | 110.22 us | 2.488 us | 6.976 us |  1.00 |    0.00 |     - |     - |     - |      80 B |
    //|                                    Array | 104.70 us | 2.050 us | 3.481 us |  0.94 |    0.08 |     - |     - |     - |      80 B |
    //|                               StructLinq |  43.85 us | 0.550 us | 0.459 us |  0.37 |    0.03 |     - |     - |     - |         - |
    //|                            RefStructLinq |  51.53 us | 1.077 us | 1.058 us |  0.44 |    0.03 |     - |     - |     - |         - |
    //|             StructLinqWithCustomComparer |  35.22 us | 0.636 us | 0.563 us |  0.30 |    0.02 |     - |     - |     - |         - |
    //| RefStructLinqZeroAllocwithCustomComparer |  21.92 us | 0.160 us | 0.149 us |  0.19 |    0.01 |     - |     - |     - |         - |


    [MemoryDiagnoser]
    public class ContainsWhereOnBigStruct
    {
        private const int Count = 10_000;
        private readonly StructContainer[] array;
        private readonly IEnumerable<StructContainer> enumerable;
        
        public ContainsWhereOnBigStruct()
        {
            array = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
            enumerable = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
        }

        [Benchmark(Baseline = true)]
        public bool Linq()
        {
            return enumerable.Where(x=> true).Contains(StructContainer.Create(5_000));
        }

        [Benchmark]
        public bool Array()
        {
            return array.Where(x=> true).Contains(StructContainer.Create(5_000));
        }

        [Benchmark]
        public bool StructLinq()
        {
            return array.ToStructEnumerable().Where(x=> true, x=>x).Contains(StructContainer.Create(5_000), x=>x);

        }

        [Benchmark]
        public bool RefStructLinq()
        {
            return array.ToRefStructEnumerable().Where((in StructContainer x)=> true, x=>x).Contains(StructContainer.Create(5_000), x=> x);
        }

        [Benchmark]
        public bool StructLinqWithCustomComparer()
        {
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            return array.ToStructEnumerable().Where(x=> true, x=>x).Contains(StructContainer.Create(5_000), comparer, x=>x);

        }

        [Benchmark]
        public bool RefStructLinqZeroAllocwithCustomComparer()
        {
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            return array.ToRefStructEnumerable().Where((in StructContainer x)=> true, x=>x).Contains(StructContainer.Create(5_000), comparer, x=> x);
        }
    }
}
