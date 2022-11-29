## SkipOnArrayWhere

### Source
[SkipOnArrayWhere.cs](../../src/StructLinq.Benchmark/SkipOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|           Method |      Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|----------------- |----------:|---------:|---------:|------:|----------:|------------:|
|             Linq | 106.98 μs | 0.253 μs | 0.224 μs |  1.00 |     104 B |        1.00 |
|       StructLinq |  27.33 μs | 0.105 μs | 0.087 μs |  0.26 |      64 B |        0.62 |
| StructLinqFaster |  30.07 μs | 0.085 μs | 0.075 μs |  0.28 |         - |        0.00 |
