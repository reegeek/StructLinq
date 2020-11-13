## IntersectOnBigStruct

### Source
[IntersectOnBigStruct.cs](../../src/StructLinq.Benchmark/IntersectOnBigStruct.cs)

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
|                      Linq | 422.0 μs | 2.05 μs | 1.91 μs |  1.00 | 199.7070 | 199.7070 | 199.7070 |  786376 B |
|                StructLinq | 149.2 μs | 0.54 μs | 0.51 μs |  0.35 |        - |        - |        - |         - |
|             RefStructLinq | 122.7 μs | 0.42 μs | 0.38 μs |  0.29 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 100.9 μs | 0.50 μs | 0.47 μs |  0.24 |        - |        - |        - |         - |
