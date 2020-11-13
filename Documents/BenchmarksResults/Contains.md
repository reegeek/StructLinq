## Contains

### Source
[Contains.cs](../../src/StructLinq.Benchmark/Contains.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|              Method |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                Linq | 1.174 us | 0.0023 us | 0.0021 us |  1.00 |      - |     - |     - |         - |
|               Array | 1.213 us | 0.0023 us | 0.0020 us |  1.03 |      - |     - |     - |         - |
|          StructLinq | 2.146 us | 0.0038 us | 0.0035 us |  1.83 | 0.0076 |     - |     - |      32 B |
| StructLinqZeroAlloc | 2.818 us | 0.0045 us | 0.0042 us |  2.40 |      - |     - |     - |         - |
