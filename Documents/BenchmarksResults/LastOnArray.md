## LastOnArray

### Source
[LastOnArray.cs](../../src/StructLinq.Benchmark/LastOnArray.cs)

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
|                Linq | 22.416 ns | 0.0913 ns | 0.0854 ns |  1.00 |      - |     - |     - |         - |
|      EnumerableLinq | 22.477 ns | 0.1117 ns | 0.1045 ns |  1.00 |      - |     - |     - |         - |
|          StructLinq | 13.596 ns | 0.0963 ns | 0.0901 ns |  0.61 | 0.0068 |     - |     - |      32 B |
| StructLinqZeroAlloc |  3.213 ns | 0.0241 ns | 0.0226 ns |  0.14 |      - |     - |     - |         - |
