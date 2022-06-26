## SkipOnArray

### Source
[SkipOnArray.cs](../../src/StructLinq.Benchmark/SkipOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | Allocated |
|----------------- |----------:|----------:|----------:|------:|----------:|
|             Linq | 68.950 μs | 0.6185 μs | 0.5785 μs |  1.00 |      48 B |
|       StructLinq | 19.763 μs | 0.1633 μs | 0.1527 μs |  0.29 |      64 B |
| StructLinqFaster |  3.572 μs | 0.0405 μs | 0.0379 μs |  0.05 |         - |
