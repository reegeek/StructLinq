## ElementAtOnArray

### Source
[ElementAtOnArray.cs](../../src/StructLinq.Benchmark/ElementAtOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                              Linq |  17.357 ns | 0.0703 ns | 0.0658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                    EnumerableLinq |  18.180 ns | 0.1057 ns | 0.0989 ns |  1.05 |    0.01 |      - |     - |     - |         - |
|                        StructLinq |  10.459 ns | 0.0734 ns | 0.0686 ns |  0.60 |    0.01 | 0.0068 |     - |     - |      32 B |
|               StructLinqZeroAlloc |   2.713 ns | 0.0170 ns | 0.0159 ns |  0.16 |    0.00 |      - |     - |     - |         - |
| StructLinqZeroAllocWithEnumerator | 673.158 ns | 3.7373 ns | 3.4959 ns | 38.78 |    0.19 |      - |     - |     - |         - |
