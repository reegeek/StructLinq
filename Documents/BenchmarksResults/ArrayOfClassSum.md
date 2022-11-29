## ArrayOfClassSum

### Source
[ArrayOfClassSum.cs](../../src/StructLinq.Benchmark/ArrayOfClassSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                         Method |       Mean |    Error |   StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|------------------------------- |-----------:|---------:|---------:|------:|-------:|----------:|------------:|
|                      Handmaded |   510.6 ns |  1.41 ns |  1.32 ns |  0.09 |      - |         - |        0.00 |
|                        LINQSum | 5,641.0 ns | 24.16 ns | 22.60 ns |  1.00 | 0.0076 |      48 B |        1.00 |
|                     StructLinq | 1,845.5 ns |  6.36 ns |  5.31 ns |  0.33 | 0.0134 |      64 B |        1.33 |
|          StructLinqWithVisitor | 5,083.9 ns | 13.81 ns | 12.92 ns |  0.90 | 0.0076 |      40 B |        0.83 |
|            StructLinqZeroAlloc |   576.0 ns |  2.76 ns |  2.58 ns |  0.10 |      - |         - |        0.00 |
| StructLinqZeroAllocWithVisitor | 3,302.8 ns | 29.39 ns | 26.05 ns |  0.59 |      - |         - |        0.00 |
