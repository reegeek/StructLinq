## Reverse

### Source
[Reverse.cs](../../src/StructLinq.Benchmark/Reverse.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                Linq | 54.02 us | 0.661 us | 0.552 us |  1.00 | 8.4229 |     - |     - |   40072 B |
|          StructLinq | 33.01 us | 0.411 us | 0.384 us |  0.61 |      - |     - |     - |      33 B |
| StructLinqZeroAlloc | 16.80 us | 0.218 us | 0.193 us |  0.31 |      - |     - |     - |         - |
