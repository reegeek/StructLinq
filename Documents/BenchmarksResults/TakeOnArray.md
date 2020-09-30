## TakeOnArray

### Source
[TakeOnArray.cs](../../src/StructLinq.Benchmark/TakeOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|             Linq | 42.215 us | 0.0550 us | 0.0460 us |  1.00 |      - |     - |     - |      48 B |
|       StructLinq | 11.992 us | 0.0649 us | 0.0607 us |  0.28 | 0.0153 |     - |     - |      64 B |
| StructLinqFaster |  2.136 us | 0.0042 us | 0.0037 us |  0.05 |      - |     - |     - |         - |
