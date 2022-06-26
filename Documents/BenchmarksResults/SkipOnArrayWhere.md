## SkipOnArrayWhere

### Source
[SkipOnArrayWhere.cs](../../src/StructLinq.Benchmark/SkipOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|           Method |      Mean |    Error |   StdDev | Ratio | Allocated |
|----------------- |----------:|---------:|---------:|------:|----------:|
|             Linq | 105.20 μs | 0.417 μs | 0.349 μs |  1.00 |     104 B |
|       StructLinq |  27.81 μs | 0.167 μs | 0.156 μs |  0.26 |      64 B |
| StructLinqFaster |  28.11 μs | 0.186 μs | 0.155 μs |  0.27 |         - |
