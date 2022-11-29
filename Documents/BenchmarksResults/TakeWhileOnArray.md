## TakeWhileOnArray

### Source
[TakeWhileOnArray.cs](../../src/StructLinq.Benchmark/TakeWhileOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                      Method |     Mean |    Error |   StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|---------------------------- |---------:|---------:|---------:|------:|-------:|----------:|------------:|
|                        Linq | 35.01 ns | 0.196 ns | 0.174 ns |  1.00 | 0.0221 |     104 B |        1.00 |
|                  StructLinq | 21.07 ns | 0.093 ns | 0.082 ns |  0.60 | 0.0068 |      32 B |        0.31 |
|         StructLinqZeroAlloc | 20.99 ns | 0.073 ns | 0.057 ns |  0.60 |      - |         - |        0.00 |
| StructLinqFunctionZeroAlloc | 21.23 ns | 0.048 ns | 0.043 ns |  0.61 |      - |         - |        0.00 |
