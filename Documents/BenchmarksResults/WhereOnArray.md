## WhereOnArray

### Source
[WhereOnArray.cs](../../src/StructLinq.Benchmark/WhereOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|----------:|----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|              Handmaded |  7.265 μs | 0.0435 μs | 0.0407 μs |  1.00 |    0.00 |      58 B |     - |     - |     - |         - |
|                   LINQ | 40.516 μs | 0.2021 μs | 0.1792 μs |  5.58 |    0.04 |     896 B |     - |     - |     - |      48 B |
|             StructLINQ | 26.134 μs | 0.1530 μs | 0.1431 μs |  3.60 |    0.03 |     632 B |     - |     - |     - |         - |
| StructLINQWithFunction | 14.716 μs | 0.0671 μs | 0.0627 μs |  2.03 |    0.02 |     495 B |     - |     - |     - |         - |
