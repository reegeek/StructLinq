## ListWhereSelectSum

### Source
[ListWhereSelectSum.cs](../../src/StructLinq.Benchmark/ListWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev | Ratio | Allocated |
|-------------------------------- |----------:|----------:|----------:|------:|----------:|
|                            LINQ | 60.381 μs | 0.4101 μs | 0.3635 μs |  1.00 |     152 B |
|          StructLinqWithDelegate | 32.504 μs | 0.3657 μs | 0.3421 μs |  0.54 |      96 B |
| StructLinqWithDelegateZeroAlloc | 27.829 μs | 0.1332 μs | 0.1246 μs |  0.46 |         - |
|             StructLinqZeroAlloc |  7.829 μs | 0.0622 μs | 0.0552 μs |  0.13 |         - |
