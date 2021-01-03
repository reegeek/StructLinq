## DistinctOnBigStruct

### Source
[DistinctOnBigStruct.cs](../../src/StructLinq.Benchmark/DistinctOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|           Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|----------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|
|             Linq | 592.9 μs | 3.90 μs | 3.65 μs |  1.00 | 379.8828 | 337.8906 | 333.0078 | 1572800 B |
|       StructLinq | 322.1 μs | 1.61 μs | 1.51 μs |  0.54 |        - |        - |        - |         - |
| RefStructLinqSum | 225.2 μs | 0.91 μs | 0.81 μs |  0.38 |        - |        - |        - |         - |
