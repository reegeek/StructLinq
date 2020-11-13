## ForEach

### Source
[ForEach.cs](../../src/StructLinq.Benchmark/ForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                      Method |      Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                  ClrForEach | 392.67 us | 0.417 us | 0.348 us |  1.00 |     - |     - |     - |      41 B |
|                  WithAction | 280.16 us | 0.314 us | 0.294 us |  0.71 |     - |     - |     - |      25 B |
|                  WithStruct |  28.34 us | 0.040 us | 0.037 us |  0.07 |     - |     - |     - |      24 B |
|         ZeroAllocWithStruct | 152.45 us | 0.074 us | 0.062 us |  0.39 |     - |     - |     - |         - |
| ToTypedEnumerableWithStruct | 420.96 us | 0.360 us | 0.319 us |  1.07 |     - |     - |     - |      65 B |
