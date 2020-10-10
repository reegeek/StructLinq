## UnionOnBigStruct

### Source
[UnionOnBigStruct.cs](../../src/StructLinq.Benchmark/UnionOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                    Method |     Mean |    Error |   StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|-------------------------- |---------:|---------:|---------:|------:|---------:|---------:|---------:|----------:|
|                      Linq | 821.6 us | 15.92 us | 14.89 us |  1.00 | 399.4141 | 399.4141 | 399.4141 | 1572797 B |
|                StructLinq | 242.2 us |  2.45 us |  2.29 us |  0.29 |        - |        - |        - |         - |
|             RefStructLinq | 198.6 us |  1.22 us |  1.08 us |  0.24 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 186.4 us |  1.98 us |  1.85 us |  0.23 |        - |        - |        - |         - |
