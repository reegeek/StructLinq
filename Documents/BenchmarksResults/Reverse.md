## Reverse

### Source
[Reverse.cs](../../src/StructLinq.Benchmark/Reverse.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|              Method |     Mean |    Error |   StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|-------------------- |---------:|---------:|---------:|------:|-------:|----------:|------------:|
|                Linq | 48.18 μs | 0.245 μs | 0.229 μs |  1.00 | 8.4229 |   40072 B |       1.000 |
|          StructLinq | 16.02 μs | 0.057 μs | 0.051 μs |  0.33 |      - |      32 B |       0.001 |
| StructLinqZeroAlloc | 14.89 μs | 0.034 μs | 0.030 μs |  0.31 |      - |         - |       0.000 |
