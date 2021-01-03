## Min

### Source
[Min.cs](../../src/StructLinq.Benchmark/Min.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|                       Handmaded |  7.497 μs | 0.0331 μs | 0.0277 μs |  1.00 |    0.00 |      24 B |     - |     - |     - |         - |
|                            LINQ | 40.086 μs | 0.2378 μs | 0.2224 μs |  5.35 |    0.04 |     519 B |     - |     - |     - |      40 B |
|                      StructLINQ |  8.629 μs | 0.1525 μs | 0.1426 μs |  1.15 |    0.02 |     188 B |     - |     - |     - |      24 B |
|             ZeroAllocStructLINQ |  9.002 μs | 0.0463 μs | 0.0433 μs |  1.20 |    0.01 |     278 B |     - |     - |     - |         - |
| ZeroAllocStructLINQOnCollection |  7.527 μs | 0.0330 μs | 0.0309 μs |  1.00 |    0.01 |     273 B |     - |     - |     - |         - |
|                      ConvertMin | 37.673 μs | 0.1985 μs | 0.1857 μs |  5.02 |    0.02 |     418 B |     - |     - |     - |      64 B |
