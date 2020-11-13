## UnionOnBigStruct

### Source
[UnionOnBigStruct.cs](../../src/StructLinq.Benchmark/UnionOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                    Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|-------------------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|
|                      Linq | 435.4 μs | 4.11 μs | 3.84 μs |  1.00 | 379.8828 | 341.7969 | 334.9609 | 1572789 B |
|                StructLinq | 232.3 μs | 1.07 μs | 1.00 μs |  0.53 |        - |        - |        - |         - |
|             RefStructLinq | 190.6 μs | 0.67 μs | 0.62 μs |  0.44 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 168.8 μs | 0.92 μs | 0.86 μs |  0.39 |        - |        - |        - |         - |
