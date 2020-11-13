## FirstOnArray

### Source
[FirstOnArray.cs](../../src/StructLinq.Benchmark/FirstOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                Linq | 21.957 ns | 0.1218 ns | 0.1080 ns |  1.00 |      - |     - |     - |         - |
|      EnumerableLinq | 21.203 ns | 0.1644 ns | 0.1372 ns |  0.97 |      - |     - |     - |         - |
|          StructLinq | 10.464 ns | 0.0365 ns | 0.0342 ns |  0.48 | 0.0068 |     - |     - |      32 B |
| StructLinqZeroAlloc |  2.519 ns | 0.0189 ns | 0.0177 ns |  0.11 |      - |     - |     - |         - |
