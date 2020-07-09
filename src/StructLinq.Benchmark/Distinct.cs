using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    //|                 Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
    //|----------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
    //|                   Linq | 578.8 us | 6.85 us | 6.40 us |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524789 B |
    //|             StructLinq | 323.3 us | 6.15 us | 6.58 us |  0.56 |       - |       - |       - |      32 B |
    //|    StructLinqZeroAlloc | 234.3 us | 1.44 us | 1.20 us |  0.41 |       - |       - |       - |         - |
    //| StructLinqZeroAllocSum | 238.2 us | 5.79 us | 5.42 us |  0.41 |       - |       - |       - |         - |

    [MemoryDiagnoser]
    public class Distinct
    {
        private const int Count = 10_000;
        private readonly int[] array;
        
        public Distinct()
        {
            var tmp = Enumerable.Range(0, Count).ToArray();
            var list = new List<int>(tmp);
            list.AddRange(tmp);
            array = list.ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Distinct())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Distinct())
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var sum = 0;
            var comparer = new StructEqualityComparer();
            foreach (var i in array.ToStructEnumerable().Distinct(comparer, x=>x))
            {
                sum += i;
            }
            return sum;
        }
        
        [Benchmark]
        public int StructLinqZeroAllocSum()
        {
            var comparer = new StructEqualityComparer();
            return array.ToStructEnumerable()
                        .Distinct(comparer, x => x)
                        .Sum(x=>x);
        }


        public readonly struct StructEqualityComparer : IEqualityComparer<int>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(int x, int y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(int value) => value.GetHashCode();
        }
    }
}