## SelectOnArray

### Source
[SelectOnArray.cs](../../src/StructLinq.Benchmark/SelectOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
|              Handmaded | 10.09 μs | 0.030 μs | 0.027 μs |  1.00 |    0.00 |         - |          NA |
|                   LINQ | 63.49 μs | 0.167 μs | 0.156 μs |  6.29 |    0.03 |      48 B |          NA |
|             StructLINQ | 20.25 μs | 0.028 μs | 0.025 μs |  2.01 |    0.00 |         - |          NA |
| StructLINQWithFunction | 13.80 μs | 0.066 μs | 0.051 μs |  1.37 |    0.01 |         - |          NA |
