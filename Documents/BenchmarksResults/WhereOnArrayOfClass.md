## WhereOnArrayOfClass

### Source
[WhereOnArrayOfClass.cs](../../src/StructLinq.Benchmark/WhereOnArrayOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|----------:|
|              Handmaded | 12.79 μs | 0.025 μs | 0.021 μs |  1.00 |    0.00 |     - |     - |     - |         - |      62 B |
|                   LINQ | 66.50 μs | 1.298 μs | 1.903 μs |  5.24 |    0.15 |     - |     - |     - |      48 B |      48 B |
|             StructLINQ | 44.21 μs | 0.834 μs | 0.856 μs |  3.47 |    0.07 |     - |     - |     - |         - |      48 B |
| StructLINQWithFunction | 19.87 μs | 0.114 μs | 0.106 μs |  1.55 |    0.01 |     - |     - |     - |         - |     494 B |
