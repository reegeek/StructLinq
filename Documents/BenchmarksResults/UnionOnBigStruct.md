## UnionOnBigStruct

### Source
[UnionOnBigStruct.cs](../../src/StructLinq.Benchmark/UnionOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                    Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
|-------------------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|------------:|
|                      Linq | 671.7 μs | 3.94 μs | 3.49 μs |  1.00 | 399.4141 | 399.4141 | 399.4141 | 1,614,503 B |
|                StructLinq | 236.2 μs | 1.67 μs | 1.56 μs |  0.35 |        - |        - |        - |           - |
|             RefStructLinq | 209.3 μs | 1.17 μs | 0.98 μs |  0.31 |        - |        - |        - |           - |
| RefStructLinqWithComparer | 184.1 μs | 1.06 μs | 0.94 μs |  0.27 |        - |        - |        - |           - |
