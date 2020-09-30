## Reverse

### Source
[Reverse.cs](../../src/StructLinq.Benchmark/Reverse.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                Linq | 54.32 us | 0.081 us | 0.068 us |  1.00 | 9.5215 |     - |     - |   40072 B |
|          StructLinq | 51.67 us | 0.031 us | 0.026 us |  0.95 |      - |     - |     - |      32 B |
| StructLinqZeroAlloc | 43.97 us | 0.033 us | 0.031 us |  0.81 |      - |     - |     - |         - |
