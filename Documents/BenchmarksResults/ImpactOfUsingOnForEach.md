## ImpactOfUsingOnForEach

### Source
[ImpactOfUsingOnForEach.cs](../../src/StructLinq.Benchmark/ImpactOfUsingOnForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                        Method |           Job |       Runtime |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size |
|------------------------------ |-------------- |-------------- |----------:|----------:|----------:|------:|--------:|----------:|
|      ForEachWithUsingOnStruct |      .NET 4.8 |      .NET 4.8 |  5.171 μs | 0.0378 μs | 0.0335 μs |  1.00 |    0.00 |     379 B |
|   ForEachWithoutUsingOnStruct |      .NET 4.8 |      .NET 4.8 |  2.585 μs | 0.0139 μs | 0.0130 μs |  0.50 |    0.00 |     360 B |
| ForEachWithTryFinallyOnStruct |      .NET 4.8 |      .NET 4.8 |  5.174 μs | 0.0327 μs | 0.0273 μs |  1.00 |    0.01 |     379 B |
|       ForEachWithUsingOnClass |      .NET 4.8 |      .NET 4.8 | 36.166 μs | 0.3454 μs | 0.3231 μs |  6.99 |    0.10 |     591 B |
|    ForEachWithoutUsingOnClass |      .NET 4.8 |      .NET 4.8 | 14.167 μs | 0.1337 μs | 0.1250 μs |  2.74 |    0.03 |     457 B |
|  ForEachWithTryFinallyOnClass |      .NET 4.8 |      .NET 4.8 | 35.867 μs | 0.2252 μs | 0.1997 μs |  6.94 |    0.05 |     591 B |
|                               |               |               |           |           |           |       |         |           |
|      ForEachWithUsingOnStruct | .NET Core 5.0 | .NET Core 5.0 |  2.610 μs | 0.0173 μs | 0.0161 μs |  1.00 |    0.00 |     153 B |
|   ForEachWithoutUsingOnStruct | .NET Core 5.0 | .NET Core 5.0 |  5.164 μs | 0.0298 μs | 0.0264 μs |  1.98 |    0.01 |     142 B |
| ForEachWithTryFinallyOnStruct | .NET Core 5.0 | .NET Core 5.0 |  2.590 μs | 0.0192 μs | 0.0180 μs |  0.99 |    0.01 |     153 B |
|       ForEachWithUsingOnClass | .NET Core 5.0 | .NET Core 5.0 | 37.933 μs | 0.3035 μs | 0.2839 μs | 14.53 |    0.12 |     393 B |
|    ForEachWithoutUsingOnClass | .NET Core 5.0 | .NET Core 5.0 |  5.146 μs | 0.0281 μs | 0.0234 μs |  1.97 |    0.02 |     142 B |
|  ForEachWithTryFinallyOnClass | .NET Core 5.0 | .NET Core 5.0 | 37.696 μs | 0.2270 μs | 0.2123 μs | 14.44 |    0.12 |     393 B |
