## Concat

### Source
[Concat.cs](../../src/StructLinq.Benchmark/Concat.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio | Allocated |
|-------------------- |---------:|---------:|---------:|------:|----------:|
|                Linq | 79.46 μs | 0.130 μs | 0.101 μs |  1.00 |     120 B |
|          StructLinq | 17.94 μs | 0.110 μs | 0.092 μs |  0.23 |      64 B |
| StructLinqZeroAlloc | 19.95 μs | 0.081 μs | 0.076 μs |  0.25 |         - |
