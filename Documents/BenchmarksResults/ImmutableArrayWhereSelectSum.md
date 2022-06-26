## ImmutableArrayWhereSelectSum

### Source
[ImmutableArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ImmutableArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|             Method |     Mean |    Error |   StdDev | Ratio | Allocated |
|------------------- |---------:|---------:|---------:|------:|----------:|
|               LINQ | 49.60 μs | 0.504 μs | 0.421 μs |  1.00 |     104 B |
|         StructLinq | 27.57 μs | 0.329 μs | 0.292 μs |  0.56 |         - |
| StructLinqFunction | 11.69 μs | 0.108 μs | 0.101 μs |  0.24 |         - |
