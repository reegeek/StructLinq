using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-8750H CPU 2.20GHz(Coffee Lake), 1 CPU, 12 logical and 6 physical cores
    //.NET Core SDK = 3.1.201

    //[Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


    //```
    //|     Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
    //|       Linq | 59.484 us | 0.1285 us | 0.1202 us |  1.00 |     - |     - |     - |      40 B |
    //| StructLinq |  5.375 us | 0.0207 us | 0.0193 us |  0.09 |     - |     - |     - |         - |

    [MemoryDiagnoser]
    public class SumOnList
    {
        private readonly List<int> list;
        public SumOnList()
        {
            list = Enumerable.Range(-1, 10000).ToList();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            return list.Sum();
        }

        [Benchmark]
        public int StructLinq()
        {
            return list.ToStructEnumerable().Sum(x => x);
        }

    }
}