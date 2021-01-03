## AnyOnArray

### Source
[AnyOnArray.cs](../../src/StructLinq.Benchmark/AnyOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                       Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                          For |   383.9 ns |  2.07 ns |  1.94 ns |  0.14 |      - |     - |     - |         - |
|                         Linq | 2,664.5 ns | 20.61 ns | 19.28 ns |  1.00 | 0.0038 |     - |     - |      32 B |
|                   StructLinq |   901.8 ns |  3.29 ns |  2.57 ns |  0.34 | 0.0067 |     - |     - |      32 B |
|          StructLinqZeroAlloc |   888.7 ns |  5.27 ns |  4.67 ns |  0.33 |      - |     - |     - |         - |
| StructLinqIFunctionZeroAlloc |   383.3 ns |  1.28 ns |  1.20 ns |  0.14 |      - |     - |     - |         - |
