## AnyOnArray

### Source
[AnyOnArray.cs](../../src/StructLinq.Benchmark/AnyOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                       Method |       Mean |    Error |   StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|----------------------------- |-----------:|---------:|---------:|------:|-------:|----------:|------------:|
|                          For |   260.1 ns |  0.77 ns |  0.68 ns |  0.09 |      - |         - |        0.00 |
|                         Linq | 2,740.4 ns | 10.82 ns | 10.12 ns |  1.00 | 0.0038 |      32 B |        1.00 |
|                   StructLinq | 1,076.2 ns | 10.84 ns |  9.06 ns |  0.39 | 0.0057 |      32 B |        1.00 |
|          StructLinqZeroAlloc | 1,019.8 ns |  2.48 ns |  2.32 ns |  0.37 |      - |         - |        0.00 |
| StructLinqIFunctionZeroAlloc |   260.8 ns |  0.91 ns |  0.85 ns |  0.10 |      - |         - |        0.00 |
