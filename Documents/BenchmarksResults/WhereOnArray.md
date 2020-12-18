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
|                 Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|----------:|----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|              Handmaded |  8.121 μs | 0.0320 μs | 0.0300 μs |  1.00 |    0.00 |      58 B |     - |     - |     - |         - |
|                   LINQ | 40.149 μs | 0.1917 μs | 0.1601 μs |  4.94 |    0.02 |     896 B |     - |     - |     - |      48 B |
|             StructLINQ | 29.332 μs | 0.2121 μs | 0.1880 μs |  3.61 |    0.03 |     632 B |     - |     - |     - |         - |
| StructLINQWithFunction | 16.885 μs | 0.0860 μs | 0.0762 μs |  2.08 |    0.01 |     495 B |     - |     - |     - |         - |
