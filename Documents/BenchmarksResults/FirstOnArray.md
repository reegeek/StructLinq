## FirstOnArray

### Source
[FirstOnArray.cs](../../src/StructLinq.Benchmark/FirstOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                Linq | 27.952 ns | 0.3868 ns | 0.3618 ns |  1.00 |      - |     - |     - |         - |
|      EnumerableLinq | 27.643 ns | 0.2212 ns | 0.2069 ns |  0.99 |      - |     - |     - |         - |
|          StructLinq | 11.636 ns | 0.1710 ns | 0.1599 ns |  0.42 | 0.0068 |     - |     - |      32 B |
| StructLinqZeroAlloc |  2.700 ns | 0.0634 ns | 0.0562 ns |  0.10 |      - |     - |     - |         - |
