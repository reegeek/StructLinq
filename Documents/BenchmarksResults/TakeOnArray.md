## TakeOnArray

### Source
[TakeOnArray.cs](../../src/StructLinq.Benchmark/TakeOnArray.cs)

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
|             Linq | 40.150 μs | 0.2370 μs | 0.2217 μs |  1.00 |      48 B |
|       StructLinq | 11.138 μs | 0.0923 μs | 0.0863 μs |  0.28 |      64 B |
| StructLinqFaster |  2.126 μs | 0.0301 μs | 0.0281 μs |  0.05 |         - |
