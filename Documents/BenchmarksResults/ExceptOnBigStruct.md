## ExceptOnBigStruct

### Source
[ExceptOnBigStruct.cs](../../src/StructLinq.Benchmark/ExceptOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                    Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|-------------------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|
|                      Linq | 652.5 μs | 3.15 μs | 2.95 μs |  1.00 | 399.4141 | 399.4141 | 399.4141 | 1572816 B |
|                StructLinq | 212.3 μs | 1.12 μs | 1.05 μs |  0.33 |        - |        - |        - |         - |
|             RefStructLinq | 183.3 μs | 0.66 μs | 0.55 μs |  0.28 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 156.5 μs | 0.51 μs | 0.45 μs |  0.24 |        - |        - |        - |         - |
