## VisitorOnArray

### Source
[VisitorOnArray.cs](../../src/StructLinq.Benchmark/VisitorOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|               Method |     Mean |   Error |  StdDev | Allocated |
|--------------------- |---------:|--------:|--------:|----------:|
|                  Sum | 550.9 ns | 3.73 ns | 3.49 ns |         - |
|              Visitor | 387.0 ns | 1.40 ns | 1.24 ns |         - |
|        VisitorOnTake | 353.1 ns | 2.64 ns | 2.06 ns |         - |
|        VisitorOnSkip | 350.8 ns | 1.34 ns | 1.12 ns |         - |
| VisitorOnSkipAndTake | 314.9 ns | 2.57 ns | 2.28 ns |         - |
