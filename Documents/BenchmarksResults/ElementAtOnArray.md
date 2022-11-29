## ElementAtOnArray

### Source
[ElementAtOnArray.cs](../../src/StructLinq.Benchmark/ElementAtOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
|                              Linq |  19.669 ns | 0.0717 ns | 0.0635 ns |  1.00 |    0.00 |      - |         - |          NA |
|                    EnumerableLinq |  15.303 ns | 0.0829 ns | 0.0692 ns |  0.78 |    0.00 |      - |         - |          NA |
|                        StructLinq |   5.627 ns | 0.0225 ns | 0.0199 ns |  0.29 |    0.00 | 0.0068 |      32 B |          NA |
|               StructLinqZeroAlloc |   1.483 ns | 0.0130 ns | 0.0109 ns |  0.08 |    0.00 |      - |         - |          NA |
| StructLinqZeroAllocWithEnumerator | 467.286 ns | 1.2378 ns | 1.0973 ns | 23.76 |    0.10 |      - |         - |          NA |
