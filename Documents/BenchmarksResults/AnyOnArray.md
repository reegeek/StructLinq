## AnyOnArray

### Source
[AnyOnArray.cs](../../src/StructLinq.Benchmark/AnyOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                       Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                          For |   388.0 ns |  2.59 ns |  2.17 ns |  0.15 |      - |     - |     - |         - |
|                         Linq | 2,555.6 ns | 14.69 ns | 13.02 ns |  1.00 | 0.0038 |     - |     - |      32 B |
|                   StructLinq | 1,065.1 ns |  3.72 ns |  3.30 ns |  0.42 | 0.0057 |     - |     - |      32 B |
|          StructLinqZeroAlloc |   898.0 ns |  4.26 ns |  3.56 ns |  0.35 |      - |     - |     - |         - |
| StructLinqIFunctionZeroAlloc |   387.0 ns |  1.05 ns |  0.93 ns |  0.15 |      - |     - |     - |         - |
