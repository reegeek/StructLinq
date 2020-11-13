## AllOnArray

### Source
[AllOnArray.cs](../../src/StructLinq.Benchmark/AllOnArray.cs)

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
|                          For |   385.1 ns |  0.86 ns |  0.81 ns |  0.14 |      - |     - |     - |         - |
|                         Linq | 2,681.8 ns | 17.46 ns | 15.48 ns |  1.00 | 0.0038 |     - |     - |      32 B |
|                   StructLinq |   908.1 ns |  4.10 ns |  3.84 ns |  0.34 | 0.0067 |     - |     - |      32 B |
|          StructLinqZeroAlloc |   896.2 ns |  4.14 ns |  3.87 ns |  0.33 |      - |     - |     - |         - |
| StructLinqIFunctionZeroAlloc |   386.2 ns |  1.41 ns |  1.32 ns |  0.14 |      - |     - |     - |         - |
