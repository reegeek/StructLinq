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
    //|         Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|--------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
    //|      SysSelect | 60.40 us | 0.705 us | 0.588 us |  1.00 |    0.00 |     - |     - |     - |      88 B |
    //| DelegateSelect | 31.94 us | 0.623 us | 0.788 us |  0.53 |    0.01 |     - |     - |     - |         - |
    //|   StructSelect | 19.14 us | 0.071 us | 0.066 us |  0.32 |    0.00 |     - |     - |     - |         - |
    //|  ConvertSelect | 44.31 us | 1.078 us | 0.956 us |  0.73 |    0.02 |     - |     - |     - |      40 B |


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
                   .Select(x => x * 2.0, x => x)
                   .Sum(x=>x);
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