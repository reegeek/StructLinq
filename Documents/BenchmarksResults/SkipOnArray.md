## SkipOnArray

### Source
[SkipOnArray.cs](../../src/StructLinq.Benchmark/SkipOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|             Linq | 78.003 us | 0.1706 us | 0.1596 us |  1.00 |     - |     - |     - |      48 B |
|       StructLinq | 22.695 us | 0.2158 us | 0.2018 us |  0.29 |     - |     - |     - |      64 B |
| StructLinqFaster |  3.850 us | 0.0094 us | 0.0078 us |  0.05 |     - |     - |     - |         - |
