## Min

### Source
[Min.cs](../../src/StructLinq.Benchmark/Min.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|             Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|             RawMin |  9.837 us | 0.0442 us | 0.0414 us |  1.00 |    0.00 |     - |     - |     - |         - |
|             SysMin | 48.108 us | 0.0786 us | 0.0735 us |  4.89 |    0.02 |     - |     - |     - |      40 B |
|          StructMin | 14.684 us | 0.0146 us | 0.0137 us |  1.49 |    0.01 |     - |     - |     - |      24 B |
| ZeroAllocStructMin | 14.675 us | 0.0159 us | 0.0149 us |  1.49 |    0.01 |     - |     - |     - |         - |
|         ConvertMin | 47.821 us | 0.0856 us | 0.0715 us |  4.86 |    0.02 |     - |     - |     - |      64 B |
