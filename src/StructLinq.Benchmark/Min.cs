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
    //|             RawMin | 10.40 us | 0.119 us | 0.111 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|             SysMin | 51.51 us | 1.088 us | 1.164 us |  4.96 |    0.16 |     - |     - |     - |      40 B |
    //|          StructMin | 10.54 us | 0.176 us | 0.164 us |  1.01 |    0.02 |     - |     - |     - |      24 B |
    //| ZeroAllocStructMin | 10.64 us | 0.222 us | 0.384 us |  1.04 |    0.05 |     - |     - |     - |         - |
    //|         ConvertMin | 53.70 us | 1.293 us | 1.270 us |  5.17 |    0.12 |     - |     - |     - |      64 B |


    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class Min
    {
        private const int Count = 10000;

        [Benchmark(Baseline = true)]
        public int RawMin()
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
        public int SysMin()
        {
            return Enumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int StructMin()
        {
            return StructEnumerable.Range(0, Count).Min();
        }

        [Benchmark]
        public int ZeroAllocStructMin()
        {
            return StructEnumerable.Range(0, Count).Min(x=>x);
        }


        [Benchmark]
        public int ConvertMin()
        {
            return Enumerable.Range(0, Count).ToStructEnumerable().Min();
        }

    }
}