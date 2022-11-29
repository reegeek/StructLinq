## ListWhereSelectSum

### Source
[ListWhereSelectSum.cs](../../src/StructLinq.Benchmark/ListWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                          Method |      Mean |     Error |    StdDev | Ratio | Allocated | Alloc Ratio |
|-------------------------------- |----------:|----------:|----------:|------:|----------:|------------:|
|                            LINQ | 52.816 μs | 0.3586 μs | 0.3354 μs |  1.00 |     152 B |        1.00 |
|          StructLinqWithDelegate | 31.221 μs | 0.5234 μs | 0.4896 μs |  0.59 |      96 B |        0.63 |
| StructLinqWithDelegateZeroAlloc | 30.393 μs | 0.1844 μs | 0.1540 μs |  0.57 |         - |        0.00 |
|             StructLinqZeroAlloc |  7.002 μs | 0.0258 μs | 0.0242 μs |  0.13 |         - |        0.00 |
