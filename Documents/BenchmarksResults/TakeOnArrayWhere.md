## TakeOnArrayWhere

### Source
[TakeOnArrayWhere.cs](../../src/StructLinq.Benchmark/TakeOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio | Allocated |
|----------------- |---------:|---------:|---------:|------:|----------:|
|             Linq | 53.23 μs | 0.212 μs | 0.198 μs |  1.00 |     104 B |
|       StructLinq | 13.25 μs | 0.098 μs | 0.091 μs |  0.25 |      64 B |
| StructLinqFaster | 16.77 μs | 0.075 μs | 0.066 μs |  0.32 |         - |
