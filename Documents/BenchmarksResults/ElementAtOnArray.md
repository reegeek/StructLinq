## ElementAtOnArray

### Source
[ElementAtOnArray.cs](../../src/StructLinq.Benchmark/ElementAtOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                              Linq |  19.360 ns | 0.0730 ns | 0.0683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                    EnumerableLinq |  19.550 ns | 0.0687 ns | 0.0609 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|                        StructLinq |  10.512 ns | 0.0600 ns | 0.0561 ns |  0.54 |    0.00 | 0.0068 |     - |     - |      32 B |
|               StructLinqZeroAlloc |   2.783 ns | 0.0201 ns | 0.0178 ns |  0.14 |    0.00 |      - |     - |     - |         - |
| StructLinqZeroAllocWithEnumerator | 671.694 ns | 2.8806 ns | 2.6945 ns | 34.70 |    0.17 |      - |     - |     - |         - |
