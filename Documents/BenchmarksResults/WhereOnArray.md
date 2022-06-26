## WhereOnArray

### Source
[WhereOnArray.cs](../../src/StructLinq.Benchmark/WhereOnArray.cs)

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
|              Handmaded |  7.111 μs | 0.0351 μs | 0.0328 μs |  1.00 |    0.00 |         - |
|                   LINQ | 42.289 μs | 0.3814 μs | 0.3381 μs |  5.94 |    0.04 |      48 B |
|             StructLINQ | 23.323 μs | 0.1883 μs | 0.1761 μs |  3.28 |    0.03 |         - |
| StructLINQWithFunction | 13.993 μs | 0.1005 μs | 0.0940 μs |  1.97 |    0.02 |         - |
