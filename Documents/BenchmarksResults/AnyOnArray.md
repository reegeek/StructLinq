## AnyOnArray

### Source
[AnyOnArray.cs](../../src/StructLinq.Benchmark/AnyOnArray.cs)

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
|                          For |   313.9 ns |  6.53 ns |  8.49 ns |   310.6 ns |  0.11 |    0.00 |      - |     - |     - |         - |
|                         Linq | 2,966.2 ns | 35.84 ns | 29.92 ns | 2,958.6 ns |  1.00 |    0.00 | 0.0076 |     - |     - |      32 B |
|                   StructLinq | 1,256.6 ns | 24.84 ns | 39.41 ns | 1,253.2 ns |  0.42 |    0.01 | 0.0076 |     - |     - |      32 B |
|          StructLinqZeroAlloc | 1,083.9 ns | 21.51 ns | 44.91 ns | 1,064.4 ns |  0.38 |    0.02 |      - |     - |     - |         - |
| StructLinqIFunctionZeroAlloc |   236.1 ns |  3.44 ns |  3.05 ns |   236.0 ns |  0.08 |    0.00 |      - |     - |     - |         - |
