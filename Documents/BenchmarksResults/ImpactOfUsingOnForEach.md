## ImpactOfUsingOnForEach

### Source
[ImpactOfUsingOnForEach.cs](../../src/StructLinq.Benchmark/ImpactOfUsingOnForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]        : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                        Method |           Job |       Runtime |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size |
|------------------------------ |-------------- |-------------- |----------:|----------:|----------:|------:|--------:|----------:|
|      ForEachWithUsingOnStruct |      .NET 4.8 |      .NET 4.8 |  5.030 μs | 0.0169 μs | 0.0150 μs |  1.00 |    0.00 |     379 B |
|   ForEachWithoutUsingOnStruct |      .NET 4.8 |      .NET 4.8 |  2.529 μs | 0.0103 μs | 0.0096 μs |  0.50 |    0.00 |     360 B |
| ForEachWithTryFinallyOnStruct |      .NET 4.8 |      .NET 4.8 |  5.030 μs | 0.0184 μs | 0.0172 μs |  1.00 |    0.01 |     379 B |
|       ForEachWithUsingOnClass |      .NET 4.8 |      .NET 4.8 | 33.208 μs | 0.1371 μs | 0.1215 μs |  6.60 |    0.03 |     591 B |
|    ForEachWithoutUsingOnClass |      .NET 4.8 |      .NET 4.8 | 12.901 μs | 0.0485 μs | 0.0453 μs |  2.57 |    0.01 |     457 B |
|  ForEachWithTryFinallyOnClass |      .NET 4.8 |      .NET 4.8 | 33.064 μs | 0.1335 μs | 0.1183 μs |  6.57 |    0.03 |     591 B |
|                               |               |               |           |           |           |       |         |           |
|      ForEachWithUsingOnStruct | .NET Core 5.0 | .NET Core 5.0 |  5.027 μs | 0.0271 μs | 0.0253 μs |  1.00 |    0.00 |     153 B |
|   ForEachWithoutUsingOnStruct | .NET Core 5.0 | .NET Core 5.0 |  5.029 μs | 0.0236 μs | 0.0221 μs |  1.00 |    0.01 |     142 B |
| ForEachWithTryFinallyOnStruct | .NET Core 5.0 | .NET Core 5.0 |  2.523 μs | 0.0093 μs | 0.0083 μs |  0.50 |    0.00 |     153 B |
|       ForEachWithUsingOnClass | .NET Core 5.0 | .NET Core 5.0 | 36.033 μs | 0.6858 μs | 0.7042 μs |  7.17 |    0.15 |     393 B |
|    ForEachWithoutUsingOnClass | .NET Core 5.0 | .NET Core 5.0 |  5.020 μs | 0.0156 μs | 0.0138 μs |  1.00 |    0.01 |     142 B |
|  ForEachWithTryFinallyOnClass | .NET Core 5.0 | .NET Core 5.0 | 30.155 μs | 0.1037 μs | 0.0919 μs |  6.00 |    0.03 |     393 B |
