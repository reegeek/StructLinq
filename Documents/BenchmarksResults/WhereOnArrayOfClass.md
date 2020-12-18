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
|                 Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|              Handmaded |  9.610 μs | 0.0691 μs | 0.0540 μs |  1.00 |    0.00 |     - |     - |     - |         - |      48 B |
|                   LINQ | 63.090 μs | 1.2080 μs | 1.0088 μs |  6.58 |    0.11 |     - |     - |     - |      48 B |      48 B |
|             StructLINQ | 39.239 μs | 0.6532 μs | 0.6110 μs |  4.08 |    0.07 |     - |     - |     - |         - |      48 B |
| StructLINQWithFunction | 19.871 μs | 0.1385 μs | 0.1156 μs |  2.07 |    0.02 |     - |     - |     - |         - |     494 B |
