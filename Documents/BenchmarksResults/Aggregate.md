## Aggregate

### Source
[Aggregate.cs](../../src/StructLinq.Benchmark/Aggregate.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                   Method |      Mean |     Error |    StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|------------------------- |----------:|----------:|----------:|------:|-------:|----------:|------------:|
|             SysAggregate | 51.079 μs | 0.1588 μs | 0.1240 μs |  1.00 |      - |      40 B |        1.00 |
|        DelegateAggregate | 17.656 μs | 0.0852 μs | 0.0797 μs |  0.35 |      - |      24 B |        0.60 |
|          StructAggregate |  2.566 μs | 0.0072 μs | 0.0067 μs |  0.05 | 0.0038 |      24 B |        0.60 |
| ZeroAllocStructAggregate | 13.639 μs | 0.1404 μs | 0.1314 μs |  0.27 |      - |         - |        0.00 |
|         ConvertAggregate | 33.087 μs | 0.1565 μs | 0.1464 μs |  0.65 |      - |      64 B |        1.60 |
