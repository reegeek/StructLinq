## ElementAtOnArray

### Source
[ElementAtOnArray.cs](../../src/StructLinq.Benchmark/ElementAtOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|
|                              Linq |  16.291 ns | 0.0645 ns | 0.0539 ns |  1.00 |    0.00 |      - |         - |
|                    EnumerableLinq |  16.145 ns | 0.0438 ns | 0.0365 ns |  0.99 |    0.00 |      - |         - |
|                        StructLinq |  11.322 ns | 0.1664 ns | 0.1557 ns |  0.70 |    0.01 | 0.0068 |      32 B |
|               StructLinqZeroAlloc |   3.090 ns | 0.0136 ns | 0.0114 ns |  0.19 |    0.00 |      - |         - |
| StructLinqZeroAllocWithEnumerator | 685.584 ns | 1.2269 ns | 1.0877 ns | 42.09 |    0.16 |      - |         - |
