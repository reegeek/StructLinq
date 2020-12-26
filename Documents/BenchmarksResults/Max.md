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
|                       Handmaded |  5.137 μs | 0.0550 μs | 0.0487 μs |  1.00 |    0.00 |     - |     - |     - |         - |      24 B |
|                            LINQ | 38.389 μs | 0.2445 μs | 0.2167 μs |  7.47 |    0.07 |     - |     - |     - |      40 B |     519 B |
|                      StructLINQ |  5.209 μs | 0.0386 μs | 0.0361 μs |  1.02 |    0.01 |     - |     - |     - |      24 B |     188 B |
|             ZeroAllocStructLINQ | 10.190 μs | 0.0429 μs | 0.0401 μs |  1.98 |    0.02 |     - |     - |     - |         - |     273 B |
| ZeroAllocStructLINQOnEnumerable |  4.274 μs | 0.0842 μs | 0.1830 μs |  0.83 |    0.03 |     - |     - |     - |         - |     278 B |
|                      ConvertMin | 40.891 μs | 0.2323 μs | 0.2173 μs |  7.96 |    0.09 |     - |     - |     - |      64 B |     418 B |
