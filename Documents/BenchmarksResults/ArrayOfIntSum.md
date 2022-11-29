## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                         Method |     Mean |   Error |  StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
|                      Handmaded | 510.9 ns | 1.20 ns | 1.00 ns |  1.40 |      - |         - |          NA |
|                 EnumerableLINQ | 363.9 ns | 1.58 ns | 1.40 ns |  1.00 |      - |         - |          NA |
|                      ArrayLINQ | 364.3 ns | 3.46 ns | 3.07 ns |  1.00 |      - |         - |          NA |
|            StructLinqZeroAlloc | 537.9 ns | 2.07 ns | 1.83 ns |  1.48 |      - |         - |          NA |
|                     StructLinq | 592.8 ns | 1.78 ns | 1.67 ns |  1.63 | 0.0067 |      32 B |          NA |
| StructLinqZeroAllocWithVisitor | 338.6 ns | 0.91 ns | 0.85 ns |  0.93 |      - |         - |          NA |
