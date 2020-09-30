## DistinctOnBigStruct

### Source
[DistinctOnBigStruct.cs](../../src/StructLinq.Benchmark/DistinctOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|----------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|
|             Linq | 724.2 us | 7.34 us | 6.86 us |  1.00 | 383.7891 | 351.5625 | 350.5859 | 1572870 B |
|       StructLinq | 362.6 us | 1.71 us | 1.60 us |  0.50 |        - |        - |        - |       1 B |
| RefStructLinqSum | 253.2 us | 0.85 us | 0.80 us |  0.35 |        - |        - |        - |       1 B |
