## TakeOnArrayWhere

### Source
[TakeOnArrayWhere.cs](../../src/StructLinq.Benchmark/TakeOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|           Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|----------------- |---------:|---------:|---------:|------:|----------:|------------:|
|             Linq | 56.22 μs | 0.189 μs | 0.177 μs |  1.00 |     104 B |        1.00 |
|       StructLinq | 12.73 μs | 0.060 μs | 0.053 μs |  0.23 |      64 B |        0.62 |
| StructLinqFaster | 16.51 μs | 0.060 μs | 0.056 μs |  0.29 |         - |        0.00 |
