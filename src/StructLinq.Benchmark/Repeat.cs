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
    //|                 Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
    //|       EnumerableRepeat | 38.829 us | 0.3285 us | 0.2912 us |  1.00 |     - |     - |     - |      32 B |
    //| StructEnumerableRepeat |  2.883 us | 0.0074 us | 0.0066 us |  0.07 |     - |     - |     - |         - |

    [MemoryDiagnoser]
    public class Repeat
    {
        private const int Count = 10000;
        private const int value = 12;
        
        [Benchmark(Baseline = true)]
        public int EnumerableRepeat()
        {
            int sum = 0;
            foreach (var result in Enumerable.Repeat(value, Count))
            {
                sum += result;
            }

            return sum;
        }

        [Benchmark]
        public int StructEnumerableRepeat()
        {
            int sum = 0;
            foreach (var result in StructEnumerable.Repeat(value, Count))
            {
                sum += result;
            }

            return sum;
        }


    }
}
