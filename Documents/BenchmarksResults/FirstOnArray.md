## FirstOnArray

### Source
[FirstOnArray.cs](../../src/StructLinq.Benchmark/FirstOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|              Method |       Mean |     Error |    StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|-------------------- |-----------:|----------:|----------:|------:|-------:|----------:|------------:|
|                Linq | 19.0034 ns | 0.1043 ns | 0.0976 ns |  1.00 |      - |         - |          NA |
|      EnumerableLinq | 19.0217 ns | 0.1192 ns | 0.1115 ns |  1.00 |      - |         - |          NA |
|          StructLinq |  5.5864 ns | 0.0322 ns | 0.0302 ns |  0.29 | 0.0068 |      32 B |          NA |
| StructLinqZeroAlloc |  0.7916 ns | 0.0179 ns | 0.0158 ns |  0.04 |      - |         - |          NA |
