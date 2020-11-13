## Repeat

### Source
[Repeat.cs](../../src/StructLinq.Benchmark/Repeat.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|       EnumerableRepeat | 36.484 us | 0.0375 us | 0.0332 us |  1.00 |     - |     - |     - |      32 B |
| StructEnumerableRepeat |  5.619 us | 0.0068 us | 0.0057 us |  0.15 |     - |     - |     - |         - |
