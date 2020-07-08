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
    //|     Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|    Default | 47.695 us | 1.2436 us | 3.6668 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //| StructLinq |  9.147 us | 0.1800 us | 0.2638 us |  0.20 |    0.02 |     - |     - |     - |         - |

    [MemoryDiagnoser]
    public class ForEachOnListOfString
    {
        private readonly List<string> list;
        public ForEachOnListOfString()
        {
            list = Enumerable.Range(-1, 10000).Select(x=> x.ToString()).ToList();
        }

        [Benchmark(Baseline = true)]
        public int Default()
        {
            var sum = 0;
            foreach (var i in list)
            {
                sum += i.Length;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in list.ToStructEnumerable())
            {
                sum += i.Length;
            }
            return sum;
        }

    }
}
