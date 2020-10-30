## ElementAtOnArray

### Source
[ElementAtOnArray.cs](../../src/StructLinq.Benchmark/ElementAtOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.403
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                Linq | 26.625 ns | 0.2574 ns | 0.2408 ns |  1.00 |      - |     - |     - |         - |
|      EnumerableLinq | 26.390 ns | 0.4745 ns | 0.3962 ns |  0.99 |      - |     - |     - |         - |
|          StructLinq | 13.418 ns | 0.2688 ns | 0.2761 ns |  0.51 | 0.0076 |     - |     - |      32 B |
| StructLinqZeroAlloc |  4.414 ns | 0.0438 ns | 0.0366 ns |  0.17 |      - |     - |     - |         - |
