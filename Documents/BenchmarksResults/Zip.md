## Zip

### Source
[Zip.cs](../../src/StructLinq.Benchmark/Zip.cs)

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
|               Linq | 62.38 μs | 0.395 μs | 0.329 μs |  1.00 |     144 B |
|         StructLinq | 11.68 μs | 0.042 μs | 0.038 μs |  0.19 |      64 B |
| StructLinqFunction | 11.70 μs | 0.064 μs | 0.060 μs |  0.19 |         - |
