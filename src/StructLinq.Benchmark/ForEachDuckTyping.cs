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
    //|                                      Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|                              ForEachOnArray |  5.217 us | 0.0336 us | 0.0314 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|                        ForEachOnIEnumerable | 39.114 us | 0.2016 us | 0.1886 us |  7.50 |    0.06 |     - |     - |     - |      32 B |
    //|              ForEachOnArrayStructEnumerable |  5.195 us | 0.0189 us | 0.0176 us |  1.00 |    0.01 |     - |     - |     - |         - |
    //| ForEachOnArrayStructEnumerableAsIEnumerable | 68.004 us | 0.1789 us | 0.1674 us | 13.04 |    0.09 |     - |     - |     - |      32 B |

    [MemoryDiagnoser]
    public class ForEachDuckTyping
    {
        private const int Count = 10_000;
        private readonly int[] array;
        private readonly IEnumerable<int> sysEnumerable;
        private readonly IEnumerable<int> arrayEnumerableAsIEnumerable;

        public ForEachDuckTyping()
        {
            array = Enumerable.Range(0, Count).ToArray();
            sysEnumerable = Enumerable.Range(0, Count).ToArray();
            arrayEnumerableAsIEnumerable = Enumerable.Range(0, Count).ToArray().ToStructEnumerable().ToEnumerable();
        }

        [Benchmark(Baseline = true)]
        public int ForEachOnArray()
        {
            var sum = 0;
            foreach (var i in array)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnIEnumerable()
        {
            var sum = 0;
            foreach (var i in sysEnumerable)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnArrayStructEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable())
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnArrayStructEnumerableAsIEnumerable()
        {
            var sum = 0;
            foreach (var i in arrayEnumerableAsIEnumerable)
            {
                sum += i;
            }
            return sum;
        }
    }
}