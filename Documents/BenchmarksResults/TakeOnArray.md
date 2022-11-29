## TakeOnArray

### Source
[TakeOnArray.cs](../../src/StructLinq.Benchmark/TakeOnArray.cs)

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
|             Linq | 39.521 μs | 0.1411 μs | 0.1320 μs |  1.00 |      48 B |        1.00 |
|       StructLinq | 11.435 μs | 0.1095 μs | 0.1024 μs |  0.29 |      64 B |        1.33 |
| StructLinqFaster |  1.793 μs | 0.0043 μs | 0.0040 μs |  0.05 |         - |        0.00 |
