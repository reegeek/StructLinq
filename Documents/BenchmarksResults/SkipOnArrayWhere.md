## SkipOnArrayWhere

### Source
[SkipOnArrayWhere.cs](../../src/StructLinq.Benchmark/SkipOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |      Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------:|---------:|---------:|------:|------:|------:|------:|----------:|
|             Linq | 116.02 us | 1.018 us | 0.952 us |  1.00 |     - |     - |     - |     105 B |
|       StructLinq |  38.32 us | 0.292 us | 0.273 us |  0.33 |     - |     - |     - |      64 B |
| StructLinqFaster |  36.06 us | 0.429 us | 0.359 us |  0.31 |     - |     - |     - |         - |
