## VisitorOnArray

### Source
[VisitorOnArray.cs](../../src/StructLinq.Benchmark/VisitorOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1081 (21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|               Method |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |---------:|--------:|--------:|------:|------:|------:|----------:|
|                  Sum | 397.5 ns | 1.45 ns | 1.36 ns |     - |     - |     - |         - |
|              Visitor | 457.5 ns | 2.21 ns | 2.06 ns |     - |     - |     - |         - |
|        VisitorOnTake | 361.4 ns | 2.18 ns | 1.93 ns |     - |     - |     - |         - |
|        VisitorOnSkip | 470.6 ns | 0.85 ns | 0.79 ns |     - |     - |     - |         - |
| VisitorOnSkipAndTake | 320.1 ns | 0.70 ns | 0.65 ns |     - |     - |     - |         - |
