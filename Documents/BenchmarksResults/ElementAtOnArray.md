## ElementAtOnArray

### Source
[ElementAtOnArray.cs](../../src/StructLinq.Benchmark/ElementAtOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                              Linq |  24.122 ns | 0.3471 ns | 0.3077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                    EnumerableLinq |  24.105 ns | 0.2221 ns | 0.2077 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|                        StructLinq |  12.324 ns | 0.2485 ns | 0.2203 ns |  0.51 |    0.01 | 0.0068 |     - |     - |      32 B |
|               StructLinqZeroAlloc |   4.066 ns | 0.0562 ns | 0.0525 ns |  0.17 |    0.00 |      - |     - |     - |         - |
| StructLinqZeroAllocWithEnumerator | 700.381 ns | 2.7479 ns | 2.5704 ns | 29.04 |    0.42 |      - |     - |     - |         - |
