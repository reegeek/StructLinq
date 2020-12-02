## ContainsWhereOnBigStruct

### Source
[ContainsWhereOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsWhereOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                                   Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                                     Linq | 92.66 us | 0.179 us | 0.168 us |  1.00 |     - |     - |     - |      81 B |
|                                    Array | 92.82 us | 0.166 us | 0.155 us |  1.00 |     - |     - |     - |      80 B |
|                               StructLinq | 43.65 us | 0.573 us | 0.508 us |  0.47 |     - |     - |     - |       1 B |
|                            RefStructLinq | 48.39 us | 0.074 us | 0.069 us |  0.52 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 34.24 us | 0.583 us | 0.517 us |  0.37 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer | 21.18 us | 0.059 us | 0.055 us |  0.23 |     - |     - |     - |         - |
