## WhereOnArray

### Source
[WhereOnArray.cs](../../src/StructLinq.Benchmark/WhereOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|              Handmaded |  8.131 μs | 0.0262 μs | 0.0218 μs |  8.137 μs |  1.00 |    0.00 |      58 B |     - |     - |     - |         - |
|                   LINQ | 46.088 μs | 0.8944 μs | 1.3388 μs | 45.395 μs |  5.82 |    0.15 |     896 B |     - |     - |     - |      48 B |
|             StructLINQ | 28.075 μs | 0.0999 μs | 0.0934 μs | 28.084 μs |  3.45 |    0.01 |     632 B |     - |     - |     - |         - |
| StructLINQWithFunction | 16.881 μs | 0.1049 μs | 0.0981 μs | 16.905 μs |  2.08 |    0.01 |     495 B |     - |     - |     - |         - |
