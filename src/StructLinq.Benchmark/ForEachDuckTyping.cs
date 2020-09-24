using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.402
    //[Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


    //```
    //|                                      Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|                                  ForOnArray |  6.264 us | 0.1056 us | 0.0988 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|                              ForEachOnArray |  4.627 us | 0.0907 us | 0.1516 us |  0.74 |    0.02 |     - |     - |     - |         - |
    //|                    ForEachOnYieldEnumerable | 51.903 us | 0.4945 us | 0.4626 us |  8.29 |    0.15 |     - |     - |     - |      57 B |
    //|                        ForEachOnIEnumerable | 46.738 us | 0.6210 us | 0.5505 us |  7.46 |    0.15 |     - |     - |     - |      32 B |
    //|              ForEachOnArrayStructEnumerable |  5.782 us | 0.0675 us | 0.0631 us |  0.92 |    0.02 |     - |     - |     - |         - |
    //| ForEachOnArrayStructEnumerableAsIEnumerable | 57.834 us | 0.4597 us | 0.4075 us |  9.24 |    0.18 |     - |     - |     - |      64 B |

    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
    public class ForEachDuckTyping
    {
        private const int Count = 10_000;
        private readonly int[] array;
        private readonly IEnumerable<int> sysEnumerable;

        public ForEachDuckTyping()
        {
            array = Enumerable.Range(0, Count).ToArray();
            sysEnumerable = Enumerable.Range(0, Count).ToArray();
        }

        private IEnumerable<int> YieldEnumerable()
        {
            var arrayLength = array.Length;
            var tab = array;
            for (int i = 0; i < arrayLength; i++)
            {
                yield return tab[i];
            }
        }

        [Benchmark(Baseline = true)]
        public int ForOnArray()
        {
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }


        [Benchmark]
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
        public int ForEachOnYieldEnumerable()
        {
            var sum = 0;
            foreach (var i in YieldEnumerable())
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
            foreach (var i in array.ToStructEnumerable().ToEnumerable())
            {
                sum += i;
            }
            return sum;
        }
    }
}