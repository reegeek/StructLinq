## AllOnArray

### Source
[AllOnArray.cs](../../src/StructLinq.Benchmark/AllOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                       Method |       Mean |    Error |   StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |-----------:|---------:|---------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|                          For |   332.5 ns |  7.10 ns | 13.68 ns |   329.9 ns |  0.10 |    0.01 |      - |     - |     - |         - |
|                         Linq | 3,471.3 ns | 67.19 ns | 84.97 ns | 3,467.4 ns |  1.00 |    0.00 | 0.0076 |     - |     - |      32 B |
|                   StructLinq | 1,080.9 ns | 21.54 ns | 48.61 ns | 1,063.1 ns |  0.32 |    0.02 | 0.0076 |     - |     - |      32 B |
|          StructLinqZeroAlloc | 1,036.4 ns | 12.66 ns | 11.22 ns | 1,035.6 ns |  0.30 |    0.01 |      - |     - |     - |         - |
| StructLinqIFunctionZeroAlloc |   237.6 ns |  6.60 ns |  5.85 ns |   235.9 ns |  0.07 |    0.00 |      - |     - |     - |         - |
