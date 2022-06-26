## Contains

### Source
[Contains.cs](../../src/StructLinq.Benchmark/Contains.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|              Method |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Allocated |
|-------------------- |---------:|----------:|----------:|------:|-------:|----------:|
|               Array | 1.447 μs | 0.0033 μs | 0.0026 μs |  1.00 |      - |         - |
|          StructLinq | 3.222 μs | 0.0108 μs | 0.0084 μs |  2.23 | 0.0038 |      32 B |
| StructLinqZeroAlloc | 1.928 μs | 0.0045 μs | 0.0037 μs |  1.33 |      - |         - |
