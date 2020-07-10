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
    //|              Method |       Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|-------------------- |-----------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
    //|                LINQ | 1,775.5 us | 29.95 us | 26.55 us |  1.00 | 27.3438 | 1.9531 |     - |  120411 B |
    //|          StructLinq |   854.7 us | 16.54 us | 15.48 us |  0.48 |       - |      - |     - |      41 B |
    //| StructLinqZeroAlloc |   329.5 us |  6.50 us | 10.68 us |  0.19 |       - |      - |     - |         - |
    

    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class OrderByArrayOfInt
    {
        private const int Count = 10_000;
        private int[] array;

        public OrderByArrayOfInt()
        {
            array = Enumerable.Range(0, Count).Reverse().ToArray();
        }

        [Benchmark(Baseline = true)]
        public int LINQ()
        {
            var sum = 0;
            foreach (var i in array.OrderBy(x=> x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().OrderBy())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var sum = 0;
            var comparer = new IntComparer();
            foreach (var i in array.ToStructEnumerable().OrderBy(comparer, x => x))
            {
                sum += i;
            }

            return sum;
        }
    }
}
