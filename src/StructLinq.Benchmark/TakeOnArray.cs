using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.302
    //[Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


    //```
    //|           Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
    //|             Linq | 49.421 us | 0.9375 us | 0.8769 us |  1.00 |     - |     - |     - |      48 B |
    //|       StructLinq |  9.620 us | 0.1588 us | 0.1485 us |  0.19 |     - |     - |     - |      32 B |
    //| StructLinqFaster |  9.680 us | 0.0686 us | 0.0608 us |  0.20 |     - |     - |     - |         - |


    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class TakeOnArray
    {
        private const int Count = 10000;
        private const int TakeCount = 5000;
        public int[] array;

        public TakeOnArray()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Take(TakeCount))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Take(TakeCount))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqFaster()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Take(TakeCount, x=>x))
            {
                sum += i;
            }

            return sum;
        }

    }
}
