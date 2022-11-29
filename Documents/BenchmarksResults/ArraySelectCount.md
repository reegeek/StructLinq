## ArraySelectCount

### Source
[ArraySelectCount.cs](../../src/StructLinq.Benchmark/ArraySelectCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|              Method |          Mean |      Error |     StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|-------------------- |--------------:|-----------:|-----------:|------:|-------:|----------:|------------:|
|                Linq | 17,691.280 ns | 64.6979 ns | 57.3530 ns | 1.000 |      - |      48 B |        1.00 |
|          StructLinq |     14.190 ns |  0.1220 ns |  0.1141 ns | 0.001 | 0.0136 |      64 B |        1.33 |
| StructLinqZeroAlloc |      1.898 ns |  0.0116 ns |  0.0108 ns | 0.000 |      - |         - |        0.00 |
