using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.101
    //[Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


    //```
    //|         Method |      Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|--------------- |----------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
    //|      SysSelect | 108.72 us | 2.147 us | 3.980 us |  1.00 |    0.00 |     - |     - |     - |      96 B |
    //| DelegateSelect |  43.17 us | 0.883 us | 1.901 us |  0.40 |    0.03 |     - |     - |     - |         - |
    //|   StructSelect |  24.58 us | 0.480 us | 0.673 us |  0.23 |    0.01 |     - |     - |     - |         - |
    //|  ConvertSelect |  61.00 us | 1.066 us | 0.997 us |  0.56 |    0.02 |     - |     - |     - |      41 B |

    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class Where
    {
        private const int Count = 10000;

        [Benchmark(Baseline = true)]
        public int SysSelect()
        {
            return Enumerable.Range(0, Count).Where(x => x > 0).Sum();
        }

        [Benchmark]
        public int DelegateSelect()
        {
            return StructEnumerable.Range(0, Count)
                                   .Where(x => x > 0)
                                   .Sum();
        }

        [Benchmark]
        public int StructSelect()
        {
            var predicate = new WhereFunc();
            return StructEnumerable.Range(0, Count).Where(ref predicate, x => x).Sum(x => x);
        }

        [Benchmark]
        public int ConvertSelect()
        {
            var predicate = new WhereFunc();
            return Enumerable.Range(0, Count).ToStructEnumerable().Where(ref predicate, x => x).Sum(x => x);
        }
    }

    struct WhereFunc : IFunction<int, bool>
    {
        public readonly bool Eval(int element)
        {
            return element > 0;
        }
    }
}

    