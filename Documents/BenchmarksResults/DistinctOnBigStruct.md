## DistinctOnBigStruct

### Source
[DistinctOnBigStruct.cs](../../src/StructLinq.Benchmark/DistinctOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|           Method |     Mean |   Error |  StdDev | Ratio |     Gen0 |     Gen1 |     Gen2 | Allocated | Alloc Ratio |
|----------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|------------:|
|             Linq | 553.9 μs | 6.92 μs | 6.47 μs |  1.00 | 395.5078 | 353.5156 | 333.0078 | 1614456 B |        1.00 |
|       StructLinq | 227.9 μs | 1.29 μs | 1.14 μs |  0.41 |        - |        - |        - |         - |        0.00 |
| RefStructLinqSum | 197.9 μs | 0.59 μs | 0.52 μs |  0.36 |        - |        - |        - |         - |        0.00 |
