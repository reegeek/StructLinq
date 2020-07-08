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
    //|                               Method |      Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|------------------------------------- |----------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
    //|                                 LINQ |  85.80 us | 1.685 us | 1.803 us |  1.00 |    0.00 |     - |     - |     - |      72 B |
    //|                   StructLinqWithFunc |  30.48 us | 0.606 us | 0.787 us |  0.36 |    0.01 |     - |     - |     - |         - |
    //|       StructLinqWithFuncAsEnumerable | 105.35 us | 2.056 us | 2.673 us |  1.24 |    0.03 |     - |     - |     - |      80 B |
    //|             StructLinqWithStructFunc |  16.89 us | 0.332 us | 0.615 us |  0.20 |    0.01 |     - |     - |     - |         - |
    //| StructLinqWithStructFuncAsEnumerable |  78.31 us | 1.049 us | 0.981 us |  0.91 |    0.02 |     - |     - |     - |      81 B |


    [MemoryDiagnoser]
    public class ForEachOnListWithSelect
    {
        private readonly List<int> list;
        public ForEachOnListWithSelect()
        {
            list = Enumerable.Range(-1, 10000).ToList();
        }

        [Benchmark(Baseline = true)]
        public int LINQ()
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
        public int StructLinqWithFuncAsEnumerable()
        {
            var sum = 0;
            foreach (var i in list.ToStructEnumerable().Select(x=> x * 2, x=>x).ToEnumerable())
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

        [Benchmark]
        public int StructLinqWithStructFuncAsEnumerable()
        {
            var sum = 0;
            var func = new Mult2();
            foreach (var i in list.ToStructEnumerable().Select(ref func, x=> x, x=> x).ToEnumerable())
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
