## TakeWhileOnArray

### Source
[TakeWhileOnArray.cs](../../src/StructLinq.Benchmark/TakeWhileOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                      Method |     Mean |    Error |   StdDev | Ratio | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------:|---------:|---------:|------:|----------:|-------:|------:|------:|----------:|
|                        Linq | 62.29 ns | 0.621 ns | 0.550 ns |  1.00 |     561 B | 0.0221 |     - |     - |     104 B |
|                  StructLinq | 26.11 ns | 0.229 ns | 0.215 ns |  0.42 |     468 B | 0.0068 |     - |     - |      32 B |
|         StructLinqZeroAlloc | 24.28 ns | 0.094 ns | 0.087 ns |  0.39 |     628 B |      - |     - |     - |         - |
| StructLinqFunctionZeroAlloc | 24.27 ns | 0.108 ns | 0.101 ns |  0.39 |     550 B |      - |     - |     - |         - |
