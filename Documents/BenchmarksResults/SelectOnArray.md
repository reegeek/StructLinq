## SelectOnArray

### Source
[SelectOnArray.cs](../../src/StructLinq.Benchmark/SelectOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|----------:|
|              Handmaded | 10.31 μs | 0.055 μs | 0.046 μs |  1.00 |    0.00 |         - |
|                   LINQ | 62.38 μs | 0.564 μs | 0.500 μs |  6.04 |    0.05 |      48 B |
|             StructLINQ | 21.51 μs | 0.160 μs | 0.150 μs |  2.08 |    0.01 |         - |
| StructLINQWithFunction | 13.93 μs | 0.070 μs | 0.062 μs |  1.35 |    0.01 |         - |
