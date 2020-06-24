using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Enumerable = System.Linq.Enumerable;

namespace StructLinq.Benchmark
{

    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.301
    //[Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


    //```
    //|           Method |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------- |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
    //|           SysSum |   592.5 ns | 0.70 ns | 0.65 ns |  0.14 |      - |     - |     - |         - |
    //| SysEnumerableSum | 4,218.3 ns | 5.87 ns | 5.49 ns |  1.00 | 0.0076 |     - |     - |      32 B |
    //|       ConvertSum | 3,938.0 ns | 6.58 ns | 6.16 ns |  0.93 | 0.0076 |     - |     - |      32 B |
    //|        StructSum |   587.6 ns | 0.89 ns | 0.79 ns |  0.14 |      - |     - |     - |         - |

    [MemoryDiagnoser]
    public class ArrayOfIntSum
    {
        private readonly IEnumerable<int> sysArray;
        private readonly int Count = 1000;
        private readonly int[] array;
        public ArrayOfIntSum()
        {
            sysArray = Enumerable.ToArray(Enumerable.Range(0,Count));
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
        }
        [Benchmark]
        public int SysSum()
        {
            int sum = 0;
            foreach (var i in array)
            {
                sum += array[i];
            }
            return sum;
        }
        [Benchmark(Baseline = true)]
        public int SysEnumerableSum() => Enumerable.Sum(sysArray);

        [Benchmark]
        public int ConvertSum() => sysArray.ToStructEnumerable().Sum(x=>x);

        [Benchmark]
        public int StructSum() => array.ToStructEnumerable().Sum(x=>x);
    }
}