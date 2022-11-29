## WhereOnArray

### Source
[WhereOnArray.cs](../../src/StructLinq.Benchmark/WhereOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|              Handmaded |  6.919 μs | 0.0233 μs | 0.0218 μs |  1.00 |    0.00 |         - |          NA |
|                   LINQ | 42.391 μs | 0.2439 μs | 0.2282 μs |  6.13 |    0.04 |      48 B |          NA |
|             StructLINQ | 25.915 μs | 0.1792 μs | 0.1589 μs |  3.74 |    0.02 |         - |          NA |
| StructLINQWithFunction | 15.200 μs | 0.0307 μs | 0.0287 μs |  2.20 |    0.01 |         - |          NA |
