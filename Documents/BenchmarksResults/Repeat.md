## Repeat

### Source
[Repeat.cs](../../src/StructLinq.Benchmark/Repeat.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method |      Mean |     Error |    StdDev | Ratio | Allocated | Alloc Ratio |
|----------------------- |----------:|----------:|----------:|------:|----------:|------------:|
|       EnumerableRepeat | 32.872 μs | 0.1363 μs | 0.1208 μs |  1.00 |      32 B |        1.00 |
| StructEnumerableRepeat |  3.657 μs | 0.0146 μs | 0.0137 μs |  0.11 |         - |        0.00 |
