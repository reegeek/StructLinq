## IntersectOnBigStruct

### Source
[IntersectOnBigStruct.cs](../../src/StructLinq.Benchmark/IntersectOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                    Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|-------------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                      Linq | 221.4 μs | 1.44 μs | 1.34 μs |  1.00 | 76.9043 | 76.9043 | 76.9043 | 280,610 B |
|                StructLinq | 157.1 μs | 0.49 μs | 0.38 μs |  0.71 |       - |       - |       - |         - |
|             RefStructLinq | 134.4 μs | 1.89 μs | 1.67 μs |  0.61 |       - |       - |       - |         - |
| RefStructLinqWithComparer | 106.1 μs | 0.71 μs | 0.67 μs |  0.48 |       - |       - |       - |         - |
