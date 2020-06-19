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
    //|           Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
    //|----------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|
    //|             Linq | 731.2 us | 6.45 us | 5.72 us |  1.00 | 385.7422 | 346.6797 | 344.7266 | 1572878 B |
    //|       StructLinq | 373.6 us | 3.07 us | 2.87 us |  0.51 |        - |        - |        - |         - |
    //| RefStructLinqSum | 256.1 us | 1.31 us | 1.23 us |  0.35 |        - |        - |        - |         - |
    
    [MemoryDiagnoser]
    public class DistinctOnBigStruct
    {
        private const int Count = 10_000;
        private readonly StructContainer[] array;
        
        public DistinctOnBigStruct()
        {
            var tmp = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
            var list = new List<StructContainer>(tmp);
            list.AddRange(tmp);
            array = list.ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            var structEqualityComparer = new StructEqualityComparer();
            foreach (var i in array.Distinct(structEqualityComparer))
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            var comparer = new StructEqualityComparer();
            foreach (var i in array.ToStructEnumerable().Distinct(comparer, x=>x))
            {
                sum += i.Element;
            }
            return sum;
        }
        
        [Benchmark]
        public int RefStructLinqSum()
        {
            var sum = 0;
            var comparer = new StructEqualityComparer();
            foreach (var i in array.ToRefStructEnumerable().Distinct(comparer, x=>x))
            {
                sum += i.Element;
            }
            return sum;
        }


        internal readonly struct StructEqualityComparer : IEqualityComparer<StructContainer>, IInEqualityComparer<StructContainer>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(StructContainer x, StructContainer y)
            {
                return x.Element == y.Element;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(StructContainer obj)
            {
                return obj.Element.GetHashCode();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in StructContainer x, in StructContainer y)
            {
                return x.Element == y.Element;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in StructContainer obj)
            {
                return obj.Element.GetHashCode();
            }

        }
    }
}
