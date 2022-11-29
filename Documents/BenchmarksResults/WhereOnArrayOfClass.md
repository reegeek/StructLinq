## WhereOnArrayOfClass

### Source
[WhereOnArrayOfClass.cs](../../src/StructLinq.Benchmark/WhereOnArrayOfClass.cs)

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
|              Handmaded |  6.956 μs | 0.0331 μs | 0.0293 μs |  1.00 |    0.00 |         - |          NA |
|                   LINQ | 47.500 μs | 0.4376 μs | 0.3654 μs |  6.83 |    0.05 |      48 B |          NA |
|             StructLINQ | 25.739 μs | 0.1956 μs | 0.1830 μs |  3.70 |    0.04 |         - |          NA |
| StructLINQWithFunction | 16.431 μs | 0.0754 μs | 0.0668 μs |  2.36 |    0.02 |         - |          NA |
