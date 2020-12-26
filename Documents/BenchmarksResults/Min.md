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
|                          Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|-------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|                       Handmaded |  7.672 μs | 0.0242 μs | 0.0189 μs |  1.00 |    0.00 |     - |     - |     - |         - |      24 B |
|                            LINQ | 40.852 μs | 0.1407 μs | 0.1175 μs |  5.32 |    0.02 |     - |     - |     - |      40 B |     519 B |
|                      StructLINQ |  8.812 μs | 0.1692 μs | 0.1662 μs |  1.15 |    0.02 |     - |     - |     - |      24 B |     188 B |
|             ZeroAllocStructLINQ |  9.339 μs | 0.0282 μs | 0.0250 μs |  1.22 |    0.00 |     - |     - |     - |         - |     278 B |
| ZeroAllocStructLINQOnCollection |  7.656 μs | 0.0218 μs | 0.0170 μs |  1.00 |    0.00 |     - |     - |     - |         - |     273 B |
|                      ConvertMin | 43.490 μs | 0.2209 μs | 0.2066 μs |  5.67 |    0.03 |     - |     - |     - |      64 B |     418 B |
