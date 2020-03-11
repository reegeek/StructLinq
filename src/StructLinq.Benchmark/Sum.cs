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
    //|     Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|     ForSum |  3.004 us | 0.0598 us | 0.1000 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|     SysSum | 40.905 us | 0.5443 us | 0.5092 us | 13.38 |    0.53 |     - |     - |     - |      40 B |
    //|  StructSum |  2.969 us | 0.0390 us | 0.0365 us |  0.97 |    0.03 |     - |     - |     - |         - |
    //| ConvertSum | 40.720 us | 0.5673 us | 0.5306 us | 13.32 |    0.58 |     - |     - |     - |      40 B |


    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class Sum
    {
        private const int Count = 10000;
        public Sum()
        {
        }


        [Benchmark(Baseline = true)]
        public int ForSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int SysSum()
        {
            return Enumerable.Range(0, Count).Sum();
        }

        [Benchmark]
        public int StructSum()
        {
            return StructEnumerable.Range(0, Count).Sum(x=>x);
        }

        [Benchmark]
        public int ConvertSum()
        {
            return Enumerable.Range(0, Count).ToStructEnumerable().Sum(x=>x);
        }

    }
}