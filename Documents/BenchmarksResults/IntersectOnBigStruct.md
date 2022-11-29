## IntersectOnBigStruct

### Source
[IntersectOnBigStruct.cs](../../src/StructLinq.Benchmark/IntersectOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                    Method |      Mean |    Error |   StdDev | Ratio |    Gen0 |    Gen1 |    Gen2 | Allocated | Alloc Ratio |
|-------------------------- |----------:|---------:|---------:|------:|--------:|--------:|--------:|----------:|------------:|
|                      Linq | 206.81 μs | 2.177 μs | 2.036 μs |  1.00 | 76.9043 | 76.9043 | 76.9043 |  280610 B |        1.00 |
|                StructLinq | 122.21 μs | 0.313 μs | 0.292 μs |  0.59 |       - |       - |       - |         - |        0.00 |
|             RefStructLinq | 103.50 μs | 0.275 μs | 0.257 μs |  0.50 |       - |       - |       - |         - |        0.00 |
| RefStructLinqWithComparer |  86.11 μs | 0.815 μs | 0.723 μs |  0.42 |       - |       - |       - |         - |        0.00 |
