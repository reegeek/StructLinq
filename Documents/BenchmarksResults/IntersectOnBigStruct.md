## IntersectOnBigStruct

### Source
[IntersectOnBigStruct.cs](../../src/StructLinq.Benchmark/IntersectOnBigStruct.cs)

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
|                      Linq | 413.1 μs | 2.10 μs | 1.96 μs |  1.00 | 199.7070 | 199.7070 | 199.7070 |  786376 B |
|                StructLinq | 148.4 μs | 0.69 μs | 0.64 μs |  0.36 |        - |        - |        - |         - |
|             RefStructLinq | 122.9 μs | 0.80 μs | 0.75 μs |  0.30 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 100.9 μs | 0.35 μs | 0.33 μs |  0.24 |        - |        - |        - |         - |
