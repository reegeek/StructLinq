using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace StructLinq.Benchmark
{

//    ``` ini

//BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
//Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
//.NET Core SDK=3.1.301
//  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
//  Job-BNPWEC : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT
//  Job-AOFHFD : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


//```
//|              Method |       Runtime | ItemCount |          Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
//|-------------------- |-------------- |---------- |--------------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
//|          SysForEach |      .NET 4.8 |         2 |     0.6424 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      .NET 4.8 |         2 |     1.4786 ns | 0.0047 ns | 0.0044 ns |  2.30 |    0.02 |     - |     - |     - |         - |
//| RefStructEnumerable |      .NET 4.8 |         2 |     4.8014 ns | 0.0075 ns | 0.0070 ns |  7.47 |    0.07 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      .NET 4.8 |         2 |     2.0580 ns | 0.0073 ns | 0.0065 ns |  3.20 |    0.03 |     - |     - |     - |         - |
//|                     |               |           |               |           |           |       |         |       |       |       |           |
//|          SysForEach | .NET Core 3.1 |         2 |     1.0824 ns | 0.0067 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable | .NET Core 3.1 |         2 |     1.4769 ns | 0.0048 ns | 0.0043 ns |  1.36 |    0.01 |     - |     - |     - |         - |
//| RefStructEnumerable | .NET Core 3.1 |         2 |     4.9266 ns | 0.0064 ns | 0.0060 ns |  4.55 |    0.02 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 | .NET Core 3.1 |         2 |     2.1925 ns | 0.0055 ns | 0.0051 ns |  2.03 |    0.01 |     - |     - |     - |         - |
//|                     |               |           |               |           |           |       |         |       |       |       |           |
//|          SysForEach |      .NET 4.8 |        20 |     8.6716 ns | 0.0709 ns | 0.0663 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      .NET 4.8 |        20 |     9.2424 ns | 0.0257 ns | 0.0215 ns |  1.07 |    0.01 |     - |     - |     - |         - |
//| RefStructEnumerable |      .NET 4.8 |        20 |    40.0729 ns | 0.0594 ns | 0.0556 ns |  4.62 |    0.04 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      .NET 4.8 |        20 |    12.0225 ns | 0.0298 ns | 0.0264 ns |  1.39 |    0.01 |     - |     - |     - |         - |
//|                     |               |           |               |           |           |       |         |       |       |       |           |
//|          SysForEach | .NET Core 3.1 |        20 |    11.3406 ns | 0.0132 ns | 0.0117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable | .NET Core 3.1 |        20 |    12.0245 ns | 0.0355 ns | 0.0332 ns |  1.06 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable | .NET Core 3.1 |        20 |    45.8248 ns | 0.0941 ns | 0.0834 ns |  4.04 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 | .NET Core 3.1 |        20 |    12.7172 ns | 0.0224 ns | 0.0199 ns |  1.12 |    0.00 |     - |     - |     - |         - |
//|                     |               |           |               |           |           |       |         |       |       |       |           |
//|          SysForEach |      .NET 4.8 |       100 |    47.1957 ns | 0.0864 ns | 0.0765 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      .NET 4.8 |       100 |    55.7280 ns | 0.0568 ns | 0.0532 ns |  1.18 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable |      .NET 4.8 |       100 |   205.1826 ns | 0.0977 ns | 0.0914 ns |  4.35 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      .NET 4.8 |       100 |    70.3530 ns | 0.1637 ns | 0.1531 ns |  1.49 |    0.00 |     - |     - |     - |         - |
//|                     |               |           |               |           |           |       |         |       |       |       |           |
//|          SysForEach | .NET Core 3.1 |       100 |    61.2430 ns | 0.0269 ns | 0.0251 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable | .NET Core 3.1 |       100 |    55.4399 ns | 0.0694 ns | 0.0649 ns |  0.91 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable | .NET Core 3.1 |       100 |   231.6778 ns | 0.3258 ns | 0.3047 ns |  3.78 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 | .NET Core 3.1 |       100 |    69.9261 ns | 0.1559 ns | 0.1458 ns |  1.14 |    0.00 |     - |     - |     - |         - |
//|                     |               |           |               |           |           |       |         |       |       |       |           |
//|          SysForEach |      .NET 4.8 |      1000 |   421.7001 ns | 0.5086 ns | 0.4758 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      .NET 4.8 |      1000 |   508.4099 ns | 0.9066 ns | 0.8480 ns |  1.21 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable |      .NET 4.8 |      1000 | 1,972.5033 ns | 4.3529 ns | 3.6349 ns |  4.68 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      .NET 4.8 |      1000 |   636.3153 ns | 0.4198 ns | 0.3506 ns |  1.51 |    0.00 |     - |     - |     - |         - |
//|                     |               |           |               |           |           |       |         |       |       |       |           |
//|          SysForEach | .NET Core 3.1 |      1000 |   567.4478 ns | 1.5388 ns | 1.4394 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable | .NET Core 3.1 |      1000 |   507.6243 ns | 0.9357 ns | 0.8752 ns |  0.89 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable | .NET Core 3.1 |      1000 | 2,249.8893 ns | 2.6163 ns | 2.4473 ns |  3.96 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 | .NET Core 3.1 |      1000 |   661.6132 ns | 1.1341 ns | 1.0608 ns |  1.17 |    0.00 |     - |     - |     - |         - |


    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class EnumeratorsOfClassComparison
    {
        private Container[] array;

        [Params(2, 20, 100, 1000)]
        public int ItemCount { get; set; }
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            array = Enumerable.Range(0, ItemCount).Select(x=> new Container(x)).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int SysForEach()
        {
            var sum = 0;
            foreach (var i in array)
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int StructEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable())
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int RefStructEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToRefStructEnumerable())
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int ArrayEnumerableV1()
        {
            var sum = 0;
            var arrayEnumerableV1 = new ArrayEnumerableV1<Container>(array);
            foreach (var i in arrayEnumerableV1)
            {
                sum += i.Element;
            }

            return sum;
        }

    }
}
