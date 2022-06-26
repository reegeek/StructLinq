## Dictionary

### Source
[Dictionary.cs](../../src/StructLinq.Benchmark/Dictionary.cs)

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
|     Method |                Job |            Runtime | ItemCount |         Mean |      Error |     StdDev | Ratio | Allocated |
|----------- |------------------- |------------------- |---------- |-------------:|-----------:|-----------:|------:|----------:|
|       **LINQ** |           **.NET 5.0** |           **.NET 5.0** |         **2** |    **18.113 ns** |  **0.0721 ns** |  **0.0639 ns** |  **0.49** |         **-** |
| StructLINQ |           .NET 5.0 |           .NET 5.0 |         2 |     3.721 ns |  0.0177 ns |  0.0157 ns |  0.10 |         - |
|       LINQ |           .NET 6.0 |           .NET 6.0 |         2 |    17.968 ns |  0.0609 ns |  0.0509 ns |  0.49 |         - |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |         2 |     3.642 ns |  0.0117 ns |  0.0110 ns |  0.10 |         - |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |         2 |    36.693 ns |  0.1020 ns |  0.0955 ns |  1.00 |         - |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     3.808 ns |  0.0131 ns |  0.0116 ns |  0.10 |         - |
|            |                    |                    |           |              |            |            |       |           |
|       **LINQ** |           **.NET 5.0** |           **.NET 5.0** |       **100** |   **469.403 ns** |  **1.1686 ns** |  **1.0931 ns** |  **0.93** |         **-** |
| StructLINQ |           .NET 5.0 |           .NET 5.0 |       100 |   138.105 ns |  0.2393 ns |  0.2239 ns |  0.27 |         - |
|       LINQ |           .NET 6.0 |           .NET 6.0 |       100 |   423.098 ns |  1.7588 ns |  1.4687 ns |  0.84 |         - |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |       100 |   134.382 ns |  0.3526 ns |  0.3125 ns |  0.27 |         - |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   504.787 ns |  1.0308 ns |  0.9138 ns |  1.00 |         - |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   137.581 ns |  0.2565 ns |  0.2273 ns |  0.27 |         - |
|            |                    |                    |           |              |            |            |       |           |
|       **LINQ** |           **.NET 5.0** |           **.NET 5.0** |      **1000** | **4,514.217 ns** | **77.6208 ns** | **72.6065 ns** |  **0.93** |         **-** |
| StructLINQ |           .NET 5.0 |           .NET 5.0 |      1000 | 1,031.241 ns |  2.5174 ns |  1.9655 ns |  0.21 |         - |
|       LINQ |           .NET 6.0 |           .NET 6.0 |      1000 | 4,300.879 ns | 42.4304 ns | 39.6895 ns |  0.88 |         - |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |      1000 | 1,287.995 ns |  3.9584 ns |  3.5090 ns |  0.26 |         - |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 4,861.507 ns | 11.5843 ns |  9.0442 ns |  1.00 |         - |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 1,327.606 ns |  3.9374 ns |  3.2879 ns |  0.27 |         - |
