## ContainsOnBigStruct

### Source
[ContainsOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                                   Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|                                     Linq |  6.379 μs | 0.0133 μs | 0.0117 μs |  1.00 |     - |     - |     - |         - |
|                                    Array |  6.350 μs | 0.0166 μs | 0.0147 μs |  1.00 |     - |     - |     - |         - |
|                               StructLinq | 22.289 μs | 0.0510 μs | 0.0398 μs |  3.49 |     - |     - |     - |         - |
|                            RefStructLinq | 16.671 μs | 0.0332 μs | 0.0311 μs |  2.61 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 15.165 μs | 0.0679 μs | 0.0602 μs |  2.38 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer |  5.093 μs | 0.0144 μs | 0.0120 μs |  0.80 |     - |     - |     - |         - |
