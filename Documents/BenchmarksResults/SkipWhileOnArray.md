## SkipWhileOnArray

### Source
[SkipWhileOnArray.cs](../../src/StructLinq.Benchmark/SkipWhileOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                      Method |     Mean |    Error |   StdDev | Ratio | Allocated |
|---------------------------- |---------:|---------:|---------:|------:|----------:|
|                        Linq | 71.41 μs | 0.775 μs | 0.724 μs |  1.00 |     104 B |
|                  StructLinq | 21.82 μs | 0.213 μs | 0.189 μs |  0.31 |      32 B |
|         StructLinqZeroAlloc | 21.76 μs | 0.133 μs | 0.118 μs |  0.30 |         - |
| StructLinqFunctionZeroAlloc | 15.10 μs | 0.035 μs | 0.031 μs |  0.21 |         - |
