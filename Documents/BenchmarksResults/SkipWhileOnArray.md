## SkipWhileOnArray

### Source
[SkipWhileOnArray.cs](../../src/StructLinq.Benchmark/SkipWhileOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                      Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|---------------------------- |---------:|---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|----------:|
|                        Linq | 90.15 μs | 1.982 μs | 5.458 μs | 87.57 μs |  1.00 |    0.00 |     - |     - |     - |     104 B |     561 B |
|                  StructLinq | 23.56 μs | 0.216 μs | 0.192 μs | 23.59 μs |  0.25 |    0.02 |     - |     - |     - |      32 B |     555 B |
|         StructLinqZeroAlloc | 24.11 μs | 0.202 μs | 0.179 μs | 24.08 μs |  0.26 |    0.02 |     - |     - |     - |         - |     714 B |
| StructLinqFunctionZeroAlloc | 16.58 μs | 0.170 μs | 0.150 μs | 16.55 μs |  0.18 |    0.01 |     - |     - |     - |         - |     636 B |
