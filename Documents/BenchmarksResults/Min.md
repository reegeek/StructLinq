## Min

### Source
[Min.cs](../../src/StructLinq.Benchmark/Min.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|-------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|
|                       Handmaded |  9.143 μs | 0.0825 μs | 0.0772 μs |  1.00 |    0.00 |         - |
|                            LINQ | 41.674 μs | 0.2803 μs | 0.2622 μs |  4.56 |    0.05 |      40 B |
|                      StructLINQ |  9.458 μs | 0.0369 μs | 0.0327 μs |  1.03 |    0.01 |      24 B |
|             ZeroAllocStructLINQ |  9.376 μs | 0.0706 μs | 0.0626 μs |  1.03 |    0.01 |         - |
| ZeroAllocStructLINQOnCollection |  9.458 μs | 0.0692 μs | 0.0647 μs |  1.03 |    0.01 |         - |
|                      ConvertMin | 36.429 μs | 0.2994 μs | 0.2801 μs |  3.98 |    0.05 |      64 B |
