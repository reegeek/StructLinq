## SumOnList

### Source
[SumOnList.cs](../../src/StructLinq.Benchmark/SumOnList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|     Method |      Mean |     Error |    StdDev | Ratio | Allocated |
|----------- |----------:|----------:|----------:|------:|----------:|
|       Linq | 59.572 μs | 0.3465 μs | 0.3242 μs |  1.00 |      40 B |
| StructLinq |  5.444 μs | 0.0244 μs | 0.0217 μs |  0.09 |         - |
