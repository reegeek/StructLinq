using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Range;

namespace StructLinq.Benchmark
{
    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.101
    //[Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


    //```
    //|                   Method |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|------------------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
    //|             SysAggregate | 61.296 us | 1.3377 us | 3.1269 us | 60.052 us |  1.00 |    0.00 |      - |     - |     - |      40 B |
    //|        DelegateAggregate | 32.539 us | 0.5096 us | 0.4767 us | 32.401 us |  0.51 |    0.03 |      - |     - |     - |      25 B |
    //|          StructAggregate |  3.078 us | 0.0610 us | 0.0571 us |  3.067 us |  0.05 |    0.00 | 0.0038 |     - |     - |      24 B |
    //| ZeroAllocStructAggregate | 15.140 us | 0.2105 us | 0.1969 us | 15.045 us |  0.24 |    0.01 |      - |     - |     - |         - |
    //|         ConvertAggregate | 44.403 us | 0.7534 us | 0.6679 us | 44.350 us |  0.70 |    0.04 |      - |     - |     - |      64 B |

    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class Aggregate
    {
        private readonly RangeEnumerable _rangeEnumerable;
        private readonly IEnumerable<int> _enumerable;
        private const int Count = 10000;
        public Aggregate()
        {
            _rangeEnumerable = StructEnumerable.Range(0, Count);
            _enumerable = Enumerable.Range(0, Count);
        }

        [Benchmark(Baseline = true)]
        public int SysAggregate()
        {
            return _enumerable.Aggregate(0, (accu, elt) => accu + elt);
        }

        [Benchmark]
        public int DelegateAggregate()
        {
            return _rangeEnumerable.Aggregate(0, (accu, elt) => accu + elt);
        }

        [Benchmark]
        public int StructAggregate()
        {
            var aggregation = new Aggregation();
            return _rangeEnumerable.Aggregate(0, ref aggregation);
        }

        [Benchmark]
        public int ZeroAllocStructAggregate()
        {
            var aggregation = new Aggregation();
            return _rangeEnumerable.Aggregate(0, ref aggregation, x=> x);
        }


        [Benchmark]
        public int ConvertAggregate()
        {
            var aggregation = new Aggregation();
            return _enumerable.ToStructEnumerable().Aggregate(0, ref aggregation);
        }
    }

    struct Aggregation : IAggregation<int, int>
    {
        public void Aggregate(int element)
        {
            Result = Result + element;
        }
        public int Result { get; set; }
    }


}