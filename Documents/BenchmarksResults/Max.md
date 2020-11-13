## Max

### Source
[Max.cs](../../src/StructLinq.Benchmark/Max.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|             Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|             RawMax |  8.436 us | 0.0083 us | 0.0074 us |  1.00 |     - |     - |     - |         - |
|             SysMax | 48.075 us | 0.1241 us | 0.1161 us |  5.70 |     - |     - |     - |      40 B |
|          StructMax | 14.695 us | 0.0146 us | 0.0137 us |  1.74 |     - |     - |     - |      24 B |
| ZeroAllocStructMax | 14.728 us | 0.0189 us | 0.0177 us |  1.75 |     - |     - |     - |         - |
|         ConvertMax | 47.900 us | 0.0769 us | 0.0720 us |  5.68 |     - |     - |     - |      64 B |
