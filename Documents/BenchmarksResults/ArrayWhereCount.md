## ArrayWhereCount

### Source
[ArrayWhereCount.cs](../../src/StructLinq.Benchmark/ArrayWhereCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                         Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|                  HandmadedCode |  6.919 μs | 0.0254 μs | 0.0212 μs |  1.00 |    0.00 |         - |          NA |
|                        SysLinq | 27.386 μs | 0.0958 μs | 0.0896 μs |  3.96 |    0.02 |      48 B |          NA |
|         StructLinqWithDelegate | 22.977 μs | 0.1799 μs | 0.1502 μs |  3.32 |    0.03 |      64 B |          NA |
| StructLinqWithDelegateZeoAlloc | 25.246 μs | 0.1429 μs | 0.1267 μs |  3.65 |    0.02 |         - |          NA |
|         StructLinqWithFunction |  6.835 μs | 0.0130 μs | 0.0115 μs |  0.99 |    0.00 |         - |          NA |
