## Max

### Source
[Max.cs](../../src/StructLinq.Benchmark/Max.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|-------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|                       Handmaded |  5.012 μs | 0.0238 μs | 0.0223 μs |  1.00 |    0.00 |     - |     - |     - |         - |      24 B |
|                            LINQ | 37.687 μs | 0.2068 μs | 0.1935 μs |  7.52 |    0.05 |     - |     - |     - |      40 B |     519 B |
|                      StructLINQ |  5.009 μs | 0.0226 μs | 0.0212 μs |  1.00 |    0.01 |     - |     - |     - |      24 B |     188 B |
|             ZeroAllocStructLINQ | 10.008 μs | 0.0426 μs | 0.0377 μs |  2.00 |    0.01 |     - |     - |     - |         - |     273 B |
| ZeroAllocStructLINQOnEnumerable |  4.585 μs | 0.0905 μs | 0.1586 μs |  0.91 |    0.03 |     - |     - |     - |         - |     278 B |
|                      ConvertMin | 40.150 μs | 0.2034 μs | 0.1903 μs |  8.01 |    0.04 |     - |     - |     - |      64 B |     418 B |
