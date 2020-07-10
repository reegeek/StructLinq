using System;
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
    //|              Method |     Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------- |---------:|----------:|----------:|------:|--------:|--------:|------:|------:|----------:|
    //|                LINQ | 2.094 ms | 0.0417 ms | 0.0480 ms |  1.00 |    0.00 | 27.3438 |     - |     - |  120400 B |
    //|          StructLinq | 1.703 ms | 0.0272 ms | 0.0227 ms |  0.81 |    0.02 |       - |     - |     - |      35 B |
    //| StructLinqZeroAlloc | 1.089 ms | 0.0122 ms | 0.0114 ms |  0.52 |    0.01 |       - |     - |     - |         - |

    

    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class OrderByArrayOfInt
    {
        private const int Count = 10_000;
        private int[] array;

        public OrderByArrayOfInt()
        {
            var rand = new Random(42);
            var list = new List<int>();
            for (int i = 0; i < Count; i++)
            {
                list.Add(rand.Next());
            }
            array = list.ToArray();
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
