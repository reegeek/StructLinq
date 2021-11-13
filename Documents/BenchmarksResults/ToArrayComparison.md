## ToArrayComparison

### Source
[ToArrayComparison.cs](../../src/StructLinq.Benchmark/ToArrayComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1081 (21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]             : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET 5.0           : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4360.0), X64 RyuJIT


```
|                  Method |                Job |            Runtime |      Mean |     Error |    StdDev |    Median | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------ |------------------- |------------------- |----------:|----------:|----------:|----------:|----------:|--------:|-------:|------:|----------:|
|       ToListThenToArray |           .NET 5.0 |           .NET 5.0 | 24.251 μs | 0.5336 μs | 1.5050 μs | 23.495 μs |      1 KB | 36.1328 | 0.0305 |     - |    167 KB |
| ToPooledListThenToArray |           .NET 5.0 |           .NET 5.0 | 17.491 μs | 0.0649 μs | 0.0542 μs | 17.480 μs |      1 KB |  8.4534 | 0.0305 |     - |     39 KB |
|      UseCountForToArray |           .NET 5.0 |           .NET 5.0 |  6.415 μs | 0.0373 μs | 0.0349 μs |  6.416 μs |      0 KB |  8.4686 | 1.0529 |     - |     39 KB |
|       StructLinqToArray |           .NET 5.0 |           .NET 5.0 | 10.723 μs | 0.0370 μs | 0.0309 μs | 10.713 μs |      0 KB |  8.4686 | 1.0529 |     - |     39 KB |
|       ToListThenToArray | .NET Framework 4.8 | .NET Framework 4.8 | 31.709 μs | 0.2780 μs | 0.2464 μs | 31.694 μs |      1 KB | 36.1328 |      - |     - |    168 KB |
| ToPooledListThenToArray | .NET Framework 4.8 | .NET Framework 4.8 | 18.716 μs | 0.0755 μs | 0.0706 μs | 18.734 μs |      2 KB |  8.4534 | 0.0305 |     - |     39 KB |
|      UseCountForToArray | .NET Framework 4.8 | .NET Framework 4.8 | 11.576 μs | 0.0319 μs | 0.0299 μs | 11.574 μs |      0 KB |  8.4686 | 0.0153 |     - |     39 KB |
|       StructLinqToArray | .NET Framework 4.8 | .NET Framework 4.8 |  7.022 μs | 0.0215 μs | 0.0180 μs |  7.026 μs |      0 KB |  8.4686 | 0.0076 |     - |     39 KB |
