## ExceptOnBigStruct

### Source
[ExceptOnBigStruct.cs](../../src/StructLinq.Benchmark/ExceptOnBigStruct.cs)

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
|                      Linq | 491.9 μs | 3.91 μs | 3.65 μs |  1.00 | 249.0234 | 249.0234 | 249.0234 |  863588 B |        1.00 |
|                StructLinq | 179.4 μs | 0.77 μs | 0.68 μs |  0.36 |        - |        - |        - |         - |        0.00 |
|             RefStructLinq | 162.1 μs | 0.61 μs | 0.54 μs |  0.33 |        - |        - |        - |         - |        0.00 |
| RefStructLinqWithComparer | 145.2 μs | 0.83 μs | 0.77 μs |  0.30 |        - |        - |        - |         - |        0.00 |
