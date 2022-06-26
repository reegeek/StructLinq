## Aggregate

### Source
[Aggregate.cs](../../src/StructLinq.Benchmark/Aggregate.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                   Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Allocated |
|------------------------- |----------:|----------:|----------:|------:|-------:|----------:|
|             SysAggregate | 51.506 μs | 0.3861 μs | 0.3224 μs |  1.00 |      - |      40 B |
|        DelegateAggregate | 15.347 μs | 0.0625 μs | 0.0554 μs |  0.30 |      - |      24 B |
|          StructAggregate |  2.597 μs | 0.0092 μs | 0.0081 μs |  0.05 | 0.0038 |      24 B |
| ZeroAllocStructAggregate | 13.719 μs | 0.0158 μs | 0.0140 μs |  0.27 |      - |         - |
|         ConvertAggregate | 38.369 μs | 0.1214 μs | 0.1076 μs |  0.74 |      - |      64 B |
