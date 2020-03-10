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
    //|      SysSelect | 66.87 us | 1.280 us | 1.524 us |  1.00 |    0.00 |     - |     - |     - |      88 B |
    //| DelegateSelect | 30.33 us | 0.606 us | 0.744 us |  0.45 |    0.02 |     - |     - |     - |         - |
    //|   StructSelect | 19.63 us | 0.213 us | 0.189 us |  0.30 |    0.01 |     - |     - |     - |         - |
    //|  ConvertSelect | 69.85 us | 1.508 us | 1.411 us |  1.05 |    0.03 |     - |     - |     - |      40 B |

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
            double sum = 0;
            var enumerable = Enumerable.Range(0, Count).Select(x=> x * 2.0);
            foreach (var i in enumerable)
            {
                sum+= i;
            }
            return sum;
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
            return Enumerable.Range(0, Count)
                      .ToStructEnumerable()
                      .Select(x=> x * 2.0, x => x)
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