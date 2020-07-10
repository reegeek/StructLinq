using System.Collections.Generic;
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
    //|           Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|           ForSum |  3.072 us | 0.0540 us | 0.0506 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|           SysSum | 41.873 us | 0.5678 us | 0.5311 us | 13.63 |    0.27 |     - |     - |     - |      40 B |
    //|        StructSum |  3.087 us | 0.0317 us | 0.0296 us |  1.00 |    0.02 |     - |     - |     - |         - |
    //| StructForEachSum |  3.090 us | 0.0300 us | 0.0281 us |  1.01 |    0.01 |     - |     - |     - |         - |
    //|       ConvertSum | 48.592 us | 0.7864 us | 0.7356 us | 15.82 |    0.28 |     - |     - |     - |      40 B |


    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class Sum
    {
        private const int Count = 10000;
        public Sum()
        {
        }


        [Benchmark(Baseline = true)]
        public int ForSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int SysSum()
        {
            return Enumerable.Range(0, Count).Sum();
        }

        [Benchmark]
        public int StructSum()
        {
            return StructEnumerable.Range(0, Count).Sum(x=>x);
        }

        [Benchmark]
        public int StructForEachSum()
        {
            var sum = 0;
            foreach (var i in StructEnumerable.Range(0, Count))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ConvertSum()
        {
            return Enumerable.Range(0, Count).ToStructEnumerable().Sum(x=>x);
        }

    }

    public struct IntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }
}