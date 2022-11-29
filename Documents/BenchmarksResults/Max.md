## Max

### Source
[Max.cs](../../src/StructLinq.Benchmark/Max.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                          Method |      Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|-------------------------------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
|                       Handmaded |  2.531 μs | 0.0067 μs | 0.0062 μs |  1.00 |    0.00 |      - |         - |          NA |
|                            LINQ | 35.526 μs | 0.1800 μs | 0.1503 μs | 14.04 |    0.07 |      - |      40 B |          NA |
|                      StructLINQ |  3.335 μs | 0.0165 μs | 0.0154 μs |  1.32 |    0.01 | 0.0038 |      24 B |          NA |
|             ZeroAllocStructLINQ |  3.152 μs | 0.0054 μs | 0.0048 μs |  1.25 |    0.00 |      - |         - |          NA |
| ZeroAllocStructLINQOnEnumerable |  4.616 μs | 0.0915 μs | 0.1763 μs |  1.84 |    0.05 |      - |         - |          NA |
|                      ConvertMin | 37.876 μs | 0.1091 μs | 0.1021 μs | 14.96 |    0.05 |      - |      64 B |          NA |
