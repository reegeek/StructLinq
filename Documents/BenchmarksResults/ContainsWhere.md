## ContainsWhere

### Source
[ContainsWhere.cs](../../src/StructLinq.Benchmark/ContainsWhere.cs)

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
|                Linq | 30.80 μs | 0.235 μs | 0.208 μs |  1.00 |      48 B |
|               Array | 30.83 μs | 0.149 μs | 0.132 μs |  1.00 |      48 B |
|          StructLinq | 13.77 μs | 0.076 μs | 0.068 μs |  0.45 |      64 B |
| StructLinqZeroAlloc | 10.28 μs | 0.031 μs | 0.029 μs |  0.33 |         - |
