## VisitorComparison

### Source
[VisitorComparison.cs](../../src/StructLinq.Benchmark/VisitorComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1081 (21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|  Method |     Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------- |---------:|--------:|--------:|------:|-------:|------:|------:|----------:|
| Foreach | 274.9 ns | 0.69 ns | 0.64 ns |  1.00 |      - |     - |     - |         - |
|   SumV1 | 203.5 ns | 0.95 ns | 0.80 ns |  0.74 |      - |     - |     - |         - |
|   SumV2 | 532.3 ns | 1.08 ns | 1.01 ns |  1.94 | 0.0067 |     - |     - |      32 B |
|   SumV3 | 264.9 ns | 1.01 ns | 0.85 ns |  0.96 |      - |     - |     - |         - |
|   SumV4 | 271.6 ns | 0.51 ns | 0.40 ns |  0.99 | 0.0067 |     - |     - |      32 B |
|   SumV5 | 268.6 ns | 0.99 ns | 0.88 ns |  0.98 |      - |     - |     - |         - |
|   SumV6 | 279.7 ns | 0.87 ns | 0.81 ns |  1.02 | 0.0067 |     - |     - |      32 B |
