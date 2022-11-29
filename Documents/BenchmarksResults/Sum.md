## Sum

### Source
[Sum.cs](../../src/StructLinq.Benchmark/Sum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|             Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|             ForSum |  2.533 μs | 0.0076 μs | 0.0064 μs |  1.00 |    0.00 |         - |          NA |
|             SysSum | 35.354 μs | 0.0890 μs | 0.0789 μs | 13.96 |    0.04 |      40 B |          NA |
|          StructSum |  5.049 μs | 0.0120 μs | 0.0100 μs |  1.99 |    0.01 |      24 B |          NA |
| StructSumZeroAlloc |  2.528 μs | 0.0137 μs | 0.0129 μs |  1.00 |    0.00 |         - |          NA |
|   StructForEachSum |  2.545 μs | 0.0270 μs | 0.0253 μs |  1.01 |    0.01 |         - |          NA |
|         ConvertSum | 37.844 μs | 0.1827 μs | 0.1620 μs | 14.95 |    0.07 |      40 B |          NA |
