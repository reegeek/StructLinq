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
    //|              Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
    //|                Linq | 20.75 us | 0.189 us | 0.177 us |     - |     - |     - |      48 B |
    //|          StructLinq | 15.57 us | 0.094 us | 0.088 us |     - |     - |     - |      32 B |
    //| StructLinqZeroAlloc | 13.72 us | 0.055 us | 0.051 us |     - |     - |     - |         - |



    [MemoryDiagnoser]
    public class ArraySelectCount
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ArraySelectCount()
        {
            array = Enumerable.Range(0, Count).ToArray();;
        }

        [Benchmark]
        public int Linq()
        {
            return array.Select(x => x * 2).Count();
        }

        [Benchmark]
        public int StructLinq()
        {
            return array.ToStructEnumerable().Select(x => x * 2).Count();
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var select = new SelectFunction();
            return array.ToStructEnumerable().Select(ref select, x=> x, x=> x).Count(x=>x);
        }

    }
}
