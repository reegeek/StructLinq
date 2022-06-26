## Repeat

### Source
[Repeat.cs](../../src/StructLinq.Benchmark/Repeat.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio | Allocated |
|----------------------- |----------:|----------:|----------:|------:|----------:|
|       EnumerableRepeat | 36.437 μs | 0.2279 μs | 0.2132 μs |  1.00 |      32 B |
| StructEnumerableRepeat |  3.782 μs | 0.0268 μs | 0.0251 μs |  0.10 |         - |
