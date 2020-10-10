## ExceptOnBigStruct

### Source
[ExceptOnBigStruct.cs](../../src/StructLinq.Benchmark/ExceptOnBigStruct.cs)

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
|                      Linq | 743.0 us | 5.41 us | 5.06 us |  1.00 | 399.4141 | 399.4141 | 399.4141 | 1572817 B |
|                StructLinq | 224.9 us | 1.57 us | 1.47 us |  0.30 |        - |        - |        - |         - |
|             RefStructLinq | 188.4 us | 1.76 us | 1.56 us |  0.25 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 167.1 us | 1.14 us | 1.01 us |  0.22 |        - |        - |        - |         - |
