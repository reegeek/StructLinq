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
|               Method |     Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |---------:|----------:|----------:|------:|------:|------:|----------:|
|                  Sum | 2.704 μs | 0.0385 μs | 0.0301 μs |     - |     - |     - |         - |
|              Visitor | 1.870 μs | 0.0027 μs | 0.0023 μs |     - |     - |     - |         - |
|        VisitorOnTake | 1.502 μs | 0.0037 μs | 0.0032 μs |     - |     - |     - |         - |
|        VisitorOnSkip | 1.838 μs | 0.0066 μs | 0.0062 μs |     - |     - |     - |         - |
| VisitorOnSkipAndTake | 1.467 μs | 0.0046 μs | 0.0040 μs |     - |     - |     - |         - |
