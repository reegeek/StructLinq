## IntersectOnBigStruct

### Source
[IntersectOnBigStruct.cs](../../src/StructLinq.Benchmark/IntersectOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                    Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|-------------------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|
|                      Linq | 430.2 us | 2.08 us | 1.95 us |  1.00 | 199.7070 | 199.7070 | 199.7070 |  786378 B |
|                StructLinq | 153.7 us | 0.70 us | 0.65 us |  0.36 |        - |        - |        - |         - |
|             RefStructLinq | 130.2 us | 0.33 us | 0.29 us |  0.30 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 103.2 us | 0.42 us | 0.37 us |  0.24 |        - |        - |        - |         - |
