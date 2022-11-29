## ImmutableArrayWhereSelectSum

### Source
[ImmutableArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ImmutableArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|             Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|------------------- |---------:|---------:|---------:|------:|----------:|------------:|
|               LINQ | 51.19 μs | 0.537 μs | 0.502 μs |  1.00 |     104 B |        1.00 |
|         StructLinq | 29.89 μs | 0.189 μs | 0.177 μs |  0.58 |         - |        0.00 |
| StructLinqFunction | 11.45 μs | 0.052 μs | 0.049 μs |  0.22 |         - |        0.00 |
