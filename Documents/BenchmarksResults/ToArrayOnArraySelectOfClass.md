## ToArrayOnArraySelectOfClass

### Source
[ToArrayOnArraySelectOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelectOfClass.cs)

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
|             Linq | 19.89 us | 0.072 us | 0.068 us |  1.00 | 9.5215 | 1.1902 |     - |  39.13 KB |
|       StructLinq | 28.17 us | 0.054 us | 0.048 us |  1.42 | 9.5215 | 1.1902 |     - |  39.12 KB |
| StructLinqFaster | 19.13 us | 0.068 us | 0.064 us |  0.96 | 9.5215 | 1.1902 |     - |  39.09 KB |
