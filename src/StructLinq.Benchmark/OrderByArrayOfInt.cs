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
    //|                     Method |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|--------------------------- |---------:|----------:|----------:|---------:|------:|--------:|--------:|-------:|------:|----------:|
    //|                       LINQ | 1.873 ms | 0.0373 ms | 0.0850 ms | 1.856 ms |  1.00 |    0.00 | 27.3438 | 1.9531 |     - |  120400 B |
    //|            StructLinqOrder | 1.516 ms | 0.0465 ms | 0.0435 ms | 1.496 ms |  0.84 |    0.03 |       - |      - |     - |      35 B |
    //|          StructLinqOrderBy | 1.601 ms | 0.0356 ms | 0.0888 ms | 1.560 ms |  0.86 |    0.07 |       - |      - |     - |      32 B |
    //|   StructLinqOrderZeroAlloc | 1.051 ms | 0.0208 ms | 0.0390 ms | 1.037 ms |  0.56 |    0.04 |       - |      - |     - |         - |
    //| StructLinqOrderByZeroAlloc | 1.062 ms | 0.0219 ms | 0.0476 ms | 1.040 ms |  0.57 |    0.04 |       - |      - |     - |         - |
    

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
        public int StructLinqOrder()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Order())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqOrderBy()
        {
            var sum = 0;
            Func<int, int> func = i => i;
            foreach (var i in array.ToStructEnumerable().OrderBy(func))
            {
                sum += i;
            }

            return sum;
        }


        [Benchmark]
        public int StructLinqOrderZeroAlloc()
        {
            var sum = 0;
            var comparer = new IntComparer();
            foreach (var i in array.ToStructEnumerable().Order(ref comparer, x => x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqOrderByZeroAlloc()
        {
            var sum = 0;
            var comparer = new IntComparer();
            var func = new Identity<int>();
            foreach (var i in array.ToStructEnumerable().OrderBy(ref func, ref comparer, x => x, x=> x))
            {
                sum += i;
            }

            return sum;
        }

    }

    public struct Identity<T> : IFunction<T, T>
    {
        public T Eval(T element)
        {
            return element;
        }
    }
}
