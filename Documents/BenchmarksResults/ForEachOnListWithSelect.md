## ForEachOnListWithSelect

### Source
[ForEachOnListWithSelect.cs](../../src/StructLinq.Benchmark/ForEachOnListWithSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                               Method |     Mean |    Error |   StdDev | Ratio | Allocated |
|------------------------------------- |---------:|---------:|---------:|------:|----------:|
|                                 LINQ | 70.70 μs | 0.370 μs | 0.328 μs |  1.00 |      72 B |
|                   StructLinqWithFunc | 17.85 μs | 0.048 μs | 0.042 μs |  0.25 |         - |
|       StructLinqWithFuncAsEnumerable | 48.43 μs | 0.192 μs | 0.170 μs |  0.68 |      88 B |
|             StructLinqWithStructFunc | 13.19 μs | 0.057 μs | 0.050 μs |  0.19 |         - |
| StructLinqWithStructFuncAsEnumerable | 43.37 μs | 0.192 μs | 0.170 μs |  0.61 |      88 B |
