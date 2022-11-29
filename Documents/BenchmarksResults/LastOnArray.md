## LastOnArray

### Source
[LastOnArray.cs](../../src/StructLinq.Benchmark/LastOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|              Method |      Mean |     Error |    StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|-------------------- |----------:|----------:|----------:|------:|-------:|----------:|------------:|
|                Linq | 18.837 ns | 0.0693 ns | 0.0649 ns |  1.00 |      - |         - |          NA |
|      EnumerableLinq | 18.736 ns | 0.0728 ns | 0.0645 ns |  0.99 |      - |         - |          NA |
|          StructLinq |  5.876 ns | 0.0341 ns | 0.0302 ns |  0.31 | 0.0068 |      32 B |          NA |
| StructLinqZeroAlloc |  1.006 ns | 0.0122 ns | 0.0114 ns |  0.05 |      - |         - |          NA |
