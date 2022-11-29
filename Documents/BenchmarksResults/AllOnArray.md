## AllOnArray

### Source
[AllOnArray.cs](../../src/StructLinq.Benchmark/AllOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                         Method |       Mean |    Error |   StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|----------------------------------------------- |-----------:|---------:|---------:|------:|-------:|----------:|------------:|
|                                            For |   175.1 ns |  0.61 ns |  0.54 ns |  0.06 |      - |         - |        0.00 |
|                                           Linq | 2,753.6 ns | 11.84 ns | 11.08 ns |  1.00 | 0.0038 |      32 B |        1.00 |
|                                     StructLinq |   907.8 ns |  3.49 ns |  2.72 ns |  0.33 | 0.0067 |      32 B |        1.00 |
|                            StructLinqZeroAlloc |   893.3 ns |  2.89 ns |  2.56 ns |  0.32 |      - |         - |        0.00 |
|                   StructLinqIFunctionZeroAlloc |   169.3 ns |  0.45 ns |  0.42 ns |  0.06 |      - |         - |        0.00 |
| StructLinqIFunctionZeroAllocOnStructEnumerable |   169.7 ns |  0.50 ns |  0.47 ns |  0.06 |      - |         - |        0.00 |
