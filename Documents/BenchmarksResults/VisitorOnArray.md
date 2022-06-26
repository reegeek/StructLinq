## VisitorOnArray

### Source
[VisitorOnArray.cs](../../src/StructLinq.Benchmark/VisitorOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]             : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET 5.0           : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0           : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT


```
|               Method |                Job |            Runtime |     Mean |   Error |  StdDev | Ratio | RatioSD | Allocated |
|--------------------- |------------------- |------------------- |---------:|--------:|--------:|------:|--------:|----------:|
|                  Sum |           .NET 5.0 |           .NET 5.0 | 554.3 ns | 3.28 ns | 3.07 ns |  1.01 |    0.01 |         - |
|                  Sum |           .NET 6.0 |           .NET 6.0 | 552.9 ns | 4.55 ns | 4.25 ns |  1.01 |    0.01 |         - |
|                  Sum | .NET Framework 4.8 | .NET Framework 4.8 | 550.1 ns | 3.22 ns | 3.02 ns |  1.00 |    0.00 |         - |
|                      |                    |                    |          |         |         |       |         |           |
|              Visitor |           .NET 5.0 |           .NET 5.0 | 392.3 ns | 6.93 ns | 6.48 ns |  1.00 |    0.02 |         - |
|              Visitor |           .NET 6.0 |           .NET 6.0 | 388.2 ns | 2.74 ns | 2.43 ns |  0.99 |    0.01 |         - |
|              Visitor | .NET Framework 4.8 | .NET Framework 4.8 | 390.6 ns | 4.11 ns | 3.84 ns |  1.00 |    0.00 |         - |
|                      |                    |                    |          |         |         |       |         |           |
|        VisitorOnTake |           .NET 5.0 |           .NET 5.0 | 358.4 ns | 5.62 ns | 4.98 ns |  1.02 |    0.02 |         - |
|        VisitorOnTake |           .NET 6.0 |           .NET 6.0 | 353.7 ns | 2.60 ns | 2.43 ns |  1.01 |    0.01 |         - |
|        VisitorOnTake | .NET Framework 4.8 | .NET Framework 4.8 | 351.8 ns | 2.13 ns | 1.89 ns |  1.00 |    0.00 |         - |
|                      |                    |                    |          |         |         |       |         |           |
|        VisitorOnSkip |           .NET 5.0 |           .NET 5.0 | 355.6 ns | 3.33 ns | 2.96 ns |  0.75 |    0.01 |         - |
|        VisitorOnSkip |           .NET 6.0 |           .NET 6.0 | 351.3 ns | 2.69 ns | 2.24 ns |  0.74 |    0.01 |         - |
|        VisitorOnSkip | .NET Framework 4.8 | .NET Framework 4.8 | 474.3 ns | 2.67 ns | 2.50 ns |  1.00 |    0.00 |         - |
|                      |                    |                    |          |         |         |       |         |           |
| VisitorOnSkipAndTake |           .NET 5.0 |           .NET 5.0 | 316.6 ns | 2.92 ns | 2.73 ns |  0.75 |    0.01 |         - |
| VisitorOnSkipAndTake |           .NET 6.0 |           .NET 6.0 | 314.0 ns | 1.89 ns | 1.77 ns |  0.74 |    0.01 |         - |
| VisitorOnSkipAndTake | .NET Framework 4.8 | .NET Framework 4.8 | 425.0 ns | 2.36 ns | 2.21 ns |  1.00 |    0.00 |         - |
