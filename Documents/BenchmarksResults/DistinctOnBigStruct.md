## DistinctOnBigStruct

### Source
[DistinctOnBigStruct.cs](../../src/StructLinq.Benchmark/DistinctOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|----------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|
|             Linq | 591.0 μs | 5.66 μs | 5.01 μs |  1.00 | 379.8828 | 336.9141 | 333.9844 | 1572779 B |
|       StructLinq | 330.6 μs | 1.70 μs | 1.59 μs |  0.56 |        - |        - |        - |         - |
| RefStructLinqSum | 231.1 μs | 1.11 μs | 1.04 μs |  0.39 |        - |        - |        - |         - |
