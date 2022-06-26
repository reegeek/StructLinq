## SelectOnArrayOfClass

### Source
[SelectOnArrayOfClass.cs](../../src/StructLinq.Benchmark/SelectOnArrayOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|----------------------- |----------:|----------:|----------:|------:|--------:|----------:|
|              Handmaded |  6.117 μs | 0.0416 μs | 0.0369 μs |  1.00 |    0.00 |         - |
|                   LINQ | 62.556 μs | 0.3746 μs | 0.3504 μs | 10.23 |    0.09 |      48 B |
|             StructLINQ | 21.188 μs | 0.1085 μs | 0.1015 μs |  3.46 |    0.03 |         - |
| StructLINQWithFunction | 15.204 μs | 0.0846 μs | 0.0750 μs |  2.49 |    0.02 |         - |
