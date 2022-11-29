## Min

### Source
[Min.cs](../../src/StructLinq.Benchmark/Min.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                          Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|                       Handmaded |  9.020 μs | 0.0610 μs | 0.0571 μs |  1.00 |    0.00 |         - |          NA |
|                            LINQ | 35.355 μs | 0.2064 μs | 0.1611 μs |  3.92 |    0.04 |      40 B |          NA |
|                      StructLINQ |  9.220 μs | 0.0220 μs | 0.0205 μs |  1.02 |    0.01 |      24 B |          NA |
|             ZeroAllocStructLINQ |  8.970 μs | 0.1315 μs | 0.1230 μs |  0.99 |    0.02 |         - |          NA |
| ZeroAllocStructLINQOnCollection |  9.225 μs | 0.0294 μs | 0.0261 μs |  1.02 |    0.01 |         - |          NA |
|                      ConvertMin | 40.582 μs | 0.2936 μs | 0.2747 μs |  4.50 |    0.04 |      64 B |          NA |
