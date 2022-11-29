## SkipWhileOnArray

### Source
[SkipWhileOnArray.cs](../../src/StructLinq.Benchmark/SkipWhileOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                      Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|---------------------------- |---------:|---------:|---------:|------:|----------:|------------:|
|                        Linq | 67.21 μs | 0.198 μs | 0.185 μs |  1.00 |     104 B |        1.00 |
|                  StructLinq | 19.71 μs | 0.077 μs | 0.069 μs |  0.29 |      32 B |        0.31 |
|         StructLinqZeroAlloc | 19.70 μs | 0.048 μs | 0.044 μs |  0.29 |         - |        0.00 |
| StructLinqFunctionZeroAlloc | 15.24 μs | 0.021 μs | 0.019 μs |  0.23 |         - |        0.00 |
