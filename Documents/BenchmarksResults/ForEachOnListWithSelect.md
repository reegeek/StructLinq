## ForEachOnListWithSelect

### Source
[ForEachOnListWithSelect.cs](../../src/StructLinq.Benchmark/ForEachOnListWithSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                               Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|------------------------------------- |---------:|---------:|---------:|------:|----------:|------------:|
|                                 LINQ | 71.18 μs | 0.499 μs | 0.416 μs |  1.00 |      72 B |        1.00 |
|                   StructLinqWithFunc | 20.24 μs | 0.103 μs | 0.096 μs |  0.28 |         - |        0.00 |
|       StructLinqWithFuncAsEnumerable | 35.36 μs | 0.074 μs | 0.069 μs |  0.50 |      88 B |        1.22 |
|             StructLinqWithStructFunc | 13.05 μs | 0.032 μs | 0.030 μs |  0.18 |         - |        0.00 |
| StructLinqWithStructFuncAsEnumerable | 27.95 μs | 0.211 μs | 0.187 μs |  0.39 |      88 B |        1.22 |
