## DistinctOnBigStruct

### Source
[DistinctOnBigStruct.cs](../../src/StructLinq.Benchmark/DistinctOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|           Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
|----------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|------------:|
|             Linq | 617.5 μs | 8.98 μs | 7.96 μs |  1.00 | 395.5078 | 353.5156 | 333.0078 | 1,614,457 B |
|       StructLinq | 333.6 μs | 2.58 μs | 2.41 μs |  0.54 |        - |        - |        - |         1 B |
| RefStructLinqSum | 251.3 μs | 2.55 μs | 2.13 μs |  0.41 |        - |        - |        - |         1 B |
