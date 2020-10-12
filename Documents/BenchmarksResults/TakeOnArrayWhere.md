## TakeOnArrayWhere

### Source
[TakeOnArrayWhere.cs](../../src/StructLinq.Benchmark/TakeOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev |   Median | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|             Linq | 61.24 us | 1.217 us | 2.672 us | 60.21 us |  1.00 |     - |     - |     - |     104 B |
|       StructLinq | 19.38 us | 0.360 us | 0.300 us | 19.44 us |  0.30 |     - |     - |     - |      64 B |
| StructLinqFaster | 21.07 us | 0.365 us | 0.285 us | 21.04 us |  0.33 |     - |     - |     - |         - |
