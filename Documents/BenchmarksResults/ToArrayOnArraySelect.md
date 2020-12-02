## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|-------:|-------:|------:|----------:|
|             Linq | 19.23 us | 0.032 us | 0.026 us |  1.00 | 9.5215 | 0.0305 |     - |  39.13 KB |
|       StructLinq | 27.65 us | 0.061 us | 0.057 us |  1.44 | 9.5215 | 0.0305 |     - |  39.12 KB |
| StructLinqFaster | 20.56 us | 0.046 us | 0.043 us |  1.07 | 9.5215 | 0.0305 |     - |  39.09 KB |
