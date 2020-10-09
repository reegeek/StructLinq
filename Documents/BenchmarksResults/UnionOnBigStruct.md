## UnionOnBigStruct

### Source
[UnionOnBigStruct.cs](../../src/StructLinq.Benchmark/UnionOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                    Method |     Mean |    Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|-------------------------- |---------:|---------:|--------:|------:|---------:|---------:|---------:|----------:|
|                      Linq | 887.9 us | 11.42 us | 9.54 us |  1.00 | 399.4141 | 399.4141 | 399.4141 | 1572793 B |
|                StructLinq | 266.5 us |  1.37 us | 1.28 us |  0.30 |        - |        - |        - |       2 B |
|             RefStructLinq | 230.6 us |  1.11 us | 0.99 us |  0.26 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 212.7 us |  0.30 us | 0.26 us |  0.24 |        - |        - |        - |         - |
