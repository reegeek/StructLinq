using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.301
    //[Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


    //```
    //|              Method |     Mean |    Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------- |---------:|---------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
    //|                Linq | 73.04 us | 4.652 us | 13.643 us | 64.60 us |  1.00 |    0.00 | 9.5215 |     - |     - |   40072 B |
    //|          StructLinq | 56.00 us | 0.290 us |  0.272 us | 55.95 us |  0.66 |    0.07 |      - |     - |     - |      33 B |
    //| StructLinqZeroAlloc | 46.67 us | 0.493 us |  0.412 us | 46.69 us |  0.55 |    0.06 |      - |     - |     - |         - |


    [MemoryDiagnoser]
    public class Reverse
    {
        private const int Count = 10000;
        private readonly int[] array;

        public Reverse()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Reverse())
            {
                sum += i;

            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Reverse())
            {
                sum += i;

            }

            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Reverse(x=>x))
            {
                sum += i;

            }

            return sum;
        }
    }
}
