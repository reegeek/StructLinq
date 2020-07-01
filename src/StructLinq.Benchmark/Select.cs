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
    //|         Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|--------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
    //|      SysSelect | 61.64 us | 0.751 us | 0.703 us |  1.00 |    0.00 |     - |     - |     - |      88 B |
    //| DelegateSelect | 26.25 us | 0.124 us | 0.110 us |  0.43 |    0.00 |     - |     - |     - |      56 B |
    //|   StructSelect | 19.29 us | 0.074 us | 0.070 us |  0.31 |    0.00 |     - |     - |     - |         - |
    //|  ConvertSelect | 47.77 us | 1.040 us | 1.316 us |  0.78 |    0.02 |     - |     - |     - |      40 B |



    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class Select
    {
        private const int Count = 10000;
        public Select()
        {
        }

        [Benchmark(Baseline = true)]
        public double SysSelect()
        {
            return Enumerable.Range(0, Count).Select(x=> x * 2.0).Sum();
        }

        [Benchmark]
        public double DelegateSelect()
        {
            return StructEnumerable
                   .Range(0, Count)
                   .Select(x => x * 2.0)
                   .Sum();
        }

        [Benchmark]
        public double StructSelect()
        {
            var multFunction = new MultFunction();
            return StructEnumerable.Range(0, Count)
                            .Select(ref multFunction, x=>x, x => x)
                            .Sum(x=> x);
        }

        [Benchmark]
        public double ConvertSelect()
        {
            var multFunction = new MultFunction();
            return Enumerable.Range(0, Count)
                      .ToStructEnumerable()
                      .Select(ref multFunction, x => x, x=> x)
                      .Sum(x=>x);
        }
    }

    readonly struct MultFunction : IFunction<int, double>
    {
        public double Eval(int element)
        {
            return element * 2.0;
        }
    }

}