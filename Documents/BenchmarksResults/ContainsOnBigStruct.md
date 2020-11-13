## ContainsOnBigStruct

### Source
[ContainsOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                                   Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                                     Linq |  5.591 us | 0.0063 us | 0.0055 us |  1.00 |    0.00 |     - |     - |     - |         - |
|                                    Array |  5.571 us | 0.0065 us | 0.0061 us |  1.00 |    0.00 |     - |     - |     - |         - |
|                               StructLinq | 25.079 us | 0.0372 us | 0.0348 us |  4.49 |    0.01 |     - |     - |     - |         - |
|                            RefStructLinq | 31.081 us | 0.0619 us | 0.0548 us |  5.56 |    0.01 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 16.231 us | 0.3306 us | 0.6449 us |  2.80 |    0.08 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer |  3.563 us | 0.0051 us | 0.0045 us |  0.64 |    0.00 |     - |     - |     - |         - |
