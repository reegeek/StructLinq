## FirstOnArray

### Source
[FirstOnArray.cs](../../src/StructLinq.Benchmark/FirstOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                Linq | 22.818 ns | 0.0981 ns | 0.0918 ns |  1.00 |      - |     - |     - |         - |
|      EnumerableLinq | 21.516 ns | 0.1063 ns | 0.0994 ns |  0.94 |      - |     - |     - |         - |
|          StructLinq | 10.620 ns | 0.0454 ns | 0.0424 ns |  0.47 | 0.0068 |     - |     - |      32 B |
| StructLinqZeroAlloc |  2.430 ns | 0.0139 ns | 0.0130 ns |  0.11 |      - |     - |     - |         - |
