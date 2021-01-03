## UnionOnBigStruct

### Source
[UnionOnBigStruct.cs](../../src/StructLinq.Benchmark/UnionOnBigStruct.cs)

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
|                      Linq | 691.7 μs | 5.36 μs | 4.47 μs |  1.00 | 399.4141 | 399.4141 | 399.4141 | 1572792 B |
|                StructLinq | 232.1 μs | 2.29 μs | 2.03 μs |  0.34 |        - |        - |        - |         - |
|             RefStructLinq | 190.9 μs | 0.66 μs | 0.62 μs |  0.28 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 166.7 μs | 0.41 μs | 0.35 μs |  0.24 |        - |        - |        - |         - |
