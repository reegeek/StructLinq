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
    //|    Default | 20.847 us | 0.1955 us | 0.1733 us |  1.00 |     - |     - |     - |         - |
    //| StructLinq |  3.948 us | 0.0090 us | 0.0084 us |  0.19 |     - |     - |     - |         - |

    [MemoryDiagnoser]
    public class ForEachOnList
    {
        private readonly List<int> list;
        public ForEachOnList()
        {
            list = Enumerable.Range(-1, 10000).ToList();
        }

        [Benchmark(Baseline = true)]
        public int Default()
        {
            var sum = 0;
            foreach (var i in list)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in list.ToStructEnumerable())
            {
                sum += i;
            }
            return sum;
        }

    }
}