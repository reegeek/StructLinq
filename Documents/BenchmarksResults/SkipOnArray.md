## SkipOnArray

### Source
[SkipOnArray.cs](../../src/StructLinq.Benchmark/SkipOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|           Method |      Mean |     Error |    StdDev | Ratio | Allocated | Alloc Ratio |
|----------------- |----------:|----------:|----------:|------:|----------:|------------:|
|             Linq | 73.639 μs | 0.2981 μs | 0.2789 μs |  1.00 |      48 B |        1.00 |
|       StructLinq | 20.212 μs | 0.0701 μs | 0.0656 μs |  0.27 |      64 B |        1.33 |
| StructLinqFaster |  3.224 μs | 0.0110 μs | 0.0103 μs |  0.04 |         - |        0.00 |
