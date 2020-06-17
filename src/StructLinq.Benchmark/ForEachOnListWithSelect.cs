using System.Collections.Generic;
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
    //|                   Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
    //|                  Default | 76.53 us | 1.020 us | 0.954 us |  1.00 |     - |     - |     - |      73 B |
    //|       StructLinqWithFunc | 27.22 us | 0.518 us | 0.576 us |  0.36 |     - |     - |     - |         - |
    //| StructLinqWithStructFunc | 15.60 us | 0.176 us | 0.165 us |  0.20 |     - |     - |     - |         - |


    [MemoryDiagnoser]
    public class ForEachOnListWithSelect
    {
        private readonly List<int> list;
        public ForEachOnListWithSelect()
        {
            list = Enumerable.Range(-1, 10000).ToList();
        }

        [Benchmark(Baseline = true)]
        public int Default()
        {
            var sum = 0;
            foreach (var i in list.Select(x=> x * 2))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqWithFunc()
        {
            var sum = 0;
            foreach (var i in list.ToStructEnumerable().Select(x=> x * 2, x=>x))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinqWithStructFunc()
        {
            var sum = 0;
            var func = new Mult2();
            foreach (var i in list.ToStructEnumerable().Select(ref func, x=> x, x=> x))
            {
                sum += i;
            }
            return sum;
        }

        public readonly struct Mult2 : IFunction<int, int>
        {
            public int Eval(int element)
            {
                return element * 2;
            }
        }

    }
}
