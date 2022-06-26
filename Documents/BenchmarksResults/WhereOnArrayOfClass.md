## WhereOnArrayOfClass

### Source
[WhereOnArrayOfClass.cs](../../src/StructLinq.Benchmark/WhereOnArrayOfClass.cs)

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
|              Handmaded |  7.273 μs | 0.0691 μs | 0.0613 μs |  1.00 |    0.00 |         - |
|                   LINQ | 45.995 μs | 0.2694 μs | 0.2388 μs |  6.32 |    0.07 |      48 B |
|             StructLINQ | 24.833 μs | 0.1490 μs | 0.1244 μs |  3.41 |    0.03 |         - |
| StructLINQWithFunction | 17.793 μs | 0.1792 μs | 0.1588 μs |  2.45 |    0.02 |         - |
