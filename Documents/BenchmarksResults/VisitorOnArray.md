## VisitorOnArray

### Source
[VisitorOnArray.cs](../../src/StructLinq.Benchmark/VisitorOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]             : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET 6.0           : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256


```
|               Method |                Job |            Runtime |     Mean |   Error |  StdDev | Ratio | Allocated | Alloc Ratio |
|--------------------- |------------------- |------------------- |---------:|--------:|--------:|------:|----------:|------------:|
|                  Sum |           .NET 6.0 |           .NET 6.0 | 537.3 ns | 1.81 ns | 1.69 ns |  1.00 |         - |          NA |
|                  Sum |           .NET 7.0 |           .NET 7.0 | 541.7 ns | 6.59 ns | 6.16 ns |  1.00 |         - |          NA |
|                  Sum | .NET Framework 4.8 | .NET Framework 4.8 | 539.6 ns | 3.12 ns | 2.91 ns |  1.00 |         - |          NA |
|                      |                    |                    |          |         |         |       |           |             |
|              Visitor |           .NET 6.0 |           .NET 6.0 | 377.6 ns | 0.97 ns | 0.86 ns |  1.00 |         - |          NA |
|              Visitor |           .NET 7.0 |           .NET 7.0 | 336.4 ns | 0.80 ns | 0.71 ns |  0.89 |         - |          NA |
|              Visitor | .NET Framework 4.8 | .NET Framework 4.8 | 378.0 ns | 1.18 ns | 1.10 ns |  1.00 |         - |          NA |
|                      |                    |                    |          |         |         |       |           |             |
|        VisitorOnTake |           .NET 6.0 |           .NET 6.0 | 342.3 ns | 1.25 ns | 1.17 ns |  0.74 |         - |          NA |
|        VisitorOnTake |           .NET 7.0 |           .NET 7.0 | 306.0 ns | 1.15 ns | 1.08 ns |  0.66 |         - |          NA |
|        VisitorOnTake | .NET Framework 4.8 | .NET Framework 4.8 | 463.5 ns | 1.97 ns | 1.54 ns |  1.00 |         - |          NA |
|                      |                    |                    |          |         |         |       |           |             |
|        VisitorOnSkip |           .NET 6.0 |           .NET 6.0 | 341.9 ns | 0.95 ns | 0.89 ns |  1.00 |         - |          NA |
|        VisitorOnSkip |           .NET 7.0 |           .NET 7.0 | 304.2 ns | 1.24 ns | 1.16 ns |  0.89 |         - |          NA |
|        VisitorOnSkip | .NET Framework 4.8 | .NET Framework 4.8 | 342.4 ns | 1.49 ns | 1.39 ns |  1.00 |         - |          NA |
|                      |                    |                    |          |         |         |       |           |             |
| VisitorOnSkipAndTake |           .NET 6.0 |           .NET 6.0 | 306.5 ns | 1.74 ns | 1.45 ns |  0.74 |         - |          NA |
| VisitorOnSkipAndTake |           .NET 7.0 |           .NET 7.0 | 272.3 ns | 1.44 ns | 1.28 ns |  0.66 |         - |          NA |
| VisitorOnSkipAndTake | .NET Framework 4.8 | .NET Framework 4.8 | 411.4 ns | 1.52 ns | 1.27 ns |  1.00 |         - |          NA |
