## ExceptOnBigStruct

### Source
[ExceptOnBigStruct.cs](../../src/StructLinq.Benchmark/ExceptOnBigStruct.cs)

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
|                      Linq | 410.3 μs | 6.01 μs | 5.62 μs |  1.00 | 380.3711 | 337.4023 | 333.4961 | 1572833 B |
|                StructLinq | 217.0 μs | 1.21 μs | 1.07 μs |  0.53 |        - |        - |        - |         - |
|             RefStructLinq | 181.2 μs | 0.52 μs | 0.49 μs |  0.44 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 157.2 μs | 0.80 μs | 0.74 μs |  0.38 |        - |        - |        - |         - |
