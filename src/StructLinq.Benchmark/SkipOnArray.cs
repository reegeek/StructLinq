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
    //|           Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
    //|             Linq | 87.92 us | 1.579 us | 1.400 us |  1.00 |     - |     - |     - |      49 B |
    //|       StructLinq | 19.21 us | 0.377 us | 0.587 us |  0.22 |     - |     - |     - |      32 B |
    //| StructLinqFaster | 18.84 us | 0.318 us | 0.298 us |  0.21 |     - |     - |     - |         - |


    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class SkipOnArray
    {
        private const int Count = 10000;
        public int[] array;

        public SkipOnArray()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Skip(1000))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Skip(1000))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqFaster()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Skip(1000, x=>x))
            {
                sum += i;
            }

            return sum;
        }

    }
}
