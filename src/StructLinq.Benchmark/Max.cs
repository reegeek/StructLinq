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
    //|             Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
    //|             RawMax | 10.34 us | 0.105 us | 0.098 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|             SysMax | 53.79 us | 0.987 us | 0.923 us |  5.20 |    0.11 |     - |     - |     - |      41 B |
    //|          StructMax | 10.45 us | 0.079 us | 0.066 us |  1.01 |    0.01 |     - |     - |     - |      24 B |
    //| ZeroAllocStructMax | 10.37 us | 0.102 us | 0.095 us |  1.00 |    0.01 |     - |     - |     - |         - |
    //|         ConvertMax | 53.59 us | 0.783 us | 0.694 us |  5.18 |    0.09 |     - |     - |     - |      64 B |

    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class Max
    {
        private const int Count = 10000;

        [Benchmark(Baseline = true)]
        public int RawMax()
        {
            var max = int.MaxValue;
            for (var index = 0; index < Count; index++)
            {
                if (index < max)
                    max = index;
            }

            return max;
        } 

        [Benchmark]
        public int SysMax()
        {
            return Enumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int StructMax()
        {
            return StructEnumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int ZeroAllocStructMax()
        {
            return StructEnumerable.Range(0, Count).Min(x=>x);
        }


        [Benchmark]
        public int ConvertMax()
        {
            return Enumerable.Range(0, Count).ToStructEnumerable().Min();
        }

    }
}