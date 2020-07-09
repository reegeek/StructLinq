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
    //|                 Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------------- |---------:|---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
    //|                   LINQ | 84.54 us | 1.676 us | 4.385 us | 82.60 us |  1.00 |    0.00 |     - |     - |     - |     152 B |
    //| StructLinqWithDelegate | 53.25 us | 1.012 us | 1.083 us | 53.01 us |  0.60 |    0.03 |     - |     - |     - |      96 B |
    //|    StructLinqZeroAlloc | 17.22 us | 0.343 us | 0.513 us | 17.12 us |  0.20 |    0.01 |     - |     - |     - |         - |

    [MemoryDiagnoser]
    public class ListWhereSelectSum
    {
        private const int Count = 10000;
        private readonly List<int> list;

        public ListWhereSelectSum()
        {
            list = Enumerable.Range(0, Count).ToList();
        }

      
        [Benchmark(Baseline = true)]
        public int LINQ() => list
                             .Where(x => (x & 1) == 0)
                             .Select(x => x * 2)
                             .Sum();

        [Benchmark]
        public int StructLinqWithDelegate()
            => list
               .ToStructEnumerable()
               .Where(x => (x & 1) == 0)
               .Select(x => x * 2)
               .Sum();


        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            return list
                   .ToStructEnumerable()
                   .Where(ref @where, x => x)
                   .Select(ref @select, x => x, x => x)
                   .Sum(x => x);
        }
    }
}
