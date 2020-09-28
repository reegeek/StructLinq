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
    //|                                   Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|                                     Linq |  5.819 us | 0.0537 us | 0.0448 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|                                    Array |  5.933 us | 0.1170 us | 0.1955 us |  1.04 |    0.03 |     - |     - |     - |         - |
    //|                               StructLinq | 22.997 us | 0.5700 us | 0.4760 us |  3.95 |    0.09 |     - |     - |     - |         - |
    //|                            RefStructLinq | 33.126 us | 0.6585 us | 1.2687 us |  5.72 |    0.23 |     - |     - |     - |         - |
    //|             StructLinqWithCustomComparer | 15.626 us | 0.0944 us | 0.0837 us |  2.69 |    0.03 |     - |     - |     - |         - |
    //| RefStructLinqZeroAllocwithCustomComparer |  3.775 us | 0.0654 us | 0.0580 us |  0.65 |    0.01 |     - |     - |     - |         - |


    [MemoryDiagnoser]
    public class ContainsOnBigStruct
    {
        private const int Count = 10_000;
        private readonly StructContainer[] array;
        private readonly IEnumerable<StructContainer> enumerable;
        
        public ContainsOnBigStruct()
        {
            array = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
            enumerable = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
        }

        [Benchmark(Baseline = true)]
        public bool Linq()
        {
            return enumerable.Contains(StructContainer.Create(5_000));
        }

        [Benchmark]
        public bool Array()
        {
            return array.Contains(StructContainer.Create(5_000));
        }

        [Benchmark]
        public bool StructLinq()
        {
            return array.ToStructEnumerable().Contains(StructContainer.Create(5_000), x=>x);

        }

        [Benchmark]
        public bool RefStructLinq()
        {
            return array.ToRefStructEnumerable().Contains(StructContainer.Create(5_000), x=> x);
        }

        [Benchmark]
        public bool StructLinqWithCustomComparer()
        {
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            return array.ToStructEnumerable().Contains(StructContainer.Create(5_000), comparer, x=>x);

        }

        [Benchmark]
        public bool RefStructLinqZeroAllocwithCustomComparer()
        {
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            return array.ToRefStructEnumerable().Contains(StructContainer.Create(5_000), comparer, x=> x);
        }
    }
}
