## ArrayOfClassSum

### Source
[ArrayOfClassSum.cs](../../src/StructLinq.Benchmark/ArrayOfClassSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1081 (21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|                         Method |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|                      Handmaded |   539.4 ns |  13.49 ns |  39.55 ns |   522.7 ns |  0.09 |    0.01 |      - |     - |     - |         - |
|                        LINQSum | 6,211.5 ns | 121.79 ns | 320.85 ns | 6,173.6 ns |  1.00 |    0.00 | 0.0076 |     - |     - |      48 B |
|                     StructLinq | 5,298.6 ns | 104.85 ns | 251.22 ns | 5,187.4 ns |  0.86 |    0.06 | 0.0076 |     - |     - |      64 B |
|          StructLinqWithVisitor | 5,462.6 ns | 106.98 ns | 160.13 ns | 5,441.5 ns |  0.88 |    0.05 | 0.0076 |     - |     - |      40 B |
|            StructLinqZeroAlloc | 4,111.0 ns |  88.13 ns | 255.68 ns | 3,987.6 ns |  0.66 |    0.05 |      - |     - |     - |         - |
| StructLinqZeroAllocWithVisitor | 4,051.6 ns |  79.28 ns | 191.48 ns | 4,036.8 ns |  0.65 |    0.04 |      - |     - |     - |         - |
