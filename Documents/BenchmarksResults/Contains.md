## Contains

### Source
[Contains.cs](../../src/StructLinq.Benchmark/Contains.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|              Method |       Mean |    Error |   StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|-------------------- |-----------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
|               Array |   376.8 ns |  1.20 ns |  1.06 ns |  1.00 |    0.00 |      - |         - |          NA |
|          StructLinq | 2,547.6 ns |  7.18 ns |  6.37 ns |  6.76 |    0.03 | 0.0038 |      32 B |          NA |
| StructLinqZeroAlloc | 1,592.9 ns | 16.87 ns | 15.78 ns |  4.23 |    0.03 |      - |         - |          NA |
