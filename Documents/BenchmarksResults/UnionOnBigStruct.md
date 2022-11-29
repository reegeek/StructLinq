## UnionOnBigStruct

### Source
[UnionOnBigStruct.cs](../../src/StructLinq.Benchmark/UnionOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                    Method |     Mean |   Error |  StdDev | Ratio |     Gen0 |     Gen1 |     Gen2 | Allocated | Alloc Ratio |
|-------------------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|------------:|
|                      Linq | 631.7 μs | 3.59 μs | 3.36 μs |  1.00 | 399.4141 | 399.4141 | 399.4141 | 1614503 B |        1.00 |
|                StructLinq | 189.2 μs | 0.76 μs | 0.71 μs |  0.30 |        - |        - |        - |         - |        0.00 |
|             RefStructLinq | 174.3 μs | 1.36 μs | 1.27 μs |  0.28 |        - |        - |        - |         - |        0.00 |
| RefStructLinqWithComparer | 145.7 μs | 0.76 μs | 0.71 μs |  0.23 |        - |        - |        - |         - |        0.00 |
