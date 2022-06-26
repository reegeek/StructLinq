## Reverse

### Source
[Reverse.cs](../../src/StructLinq.Benchmark/Reverse.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|-------:|----------:|
|                Linq | 49.73 μs | 0.147 μs | 0.123 μs |  1.00 | 8.4229 |  40,072 B |
|          StructLinq | 15.77 μs | 0.105 μs | 0.098 μs |  0.32 |      - |      32 B |
| StructLinqZeroAlloc | 15.73 μs | 0.096 μs | 0.080 μs |  0.32 |      - |         - |
