## LastOnArray

### Source
[LastOnArray.cs](../../src/StructLinq.Benchmark/LastOnArray.cs)

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
|                Linq | 22.362 ns | 0.0964 ns | 0.0901 ns |  1.00 |      - |     - |     - |         - |
|      EnumerableLinq | 22.377 ns | 0.0860 ns | 0.0804 ns |  1.00 |      - |     - |     - |         - |
|          StructLinq | 13.014 ns | 0.2446 ns | 0.2169 ns |  0.58 | 0.0068 |     - |     - |      32 B |
| StructLinqZeroAlloc |  3.048 ns | 0.0221 ns | 0.0207 ns |  0.14 |      - |     - |     - |         - |
