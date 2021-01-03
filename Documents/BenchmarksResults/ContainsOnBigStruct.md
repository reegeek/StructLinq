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
|                                   Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                                     Linq |  5.342 μs | 0.0205 μs | 0.0192 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                                    Array |  4.678 μs | 0.0246 μs | 0.0230 μs |  0.88 |    0.00 |     - |     - |     - |         - |
|                               StructLinq | 23.504 μs | 0.1103 μs | 0.0977 μs |  4.40 |    0.02 |     - |     - |     - |         - |
|                            RefStructLinq | 17.033 μs | 0.0842 μs | 0.0787 μs |  3.19 |    0.02 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 14.999 μs | 0.0528 μs | 0.0468 μs |  2.81 |    0.01 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer |  5.025 μs | 0.0157 μs | 0.0147 μs |  0.94 |    0.00 |     - |     - |     - |         - |
