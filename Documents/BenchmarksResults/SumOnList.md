## SumOnList

### Source
[SumOnList.cs](../../src/StructLinq.Benchmark/SumOnList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|     Method |     Mean |     Error |    StdDev | Ratio | Allocated | Alloc Ratio |
|----------- |---------:|----------:|----------:|------:|----------:|------------:|
|       Linq | 3.578 μs | 0.0145 μs | 0.0136 μs |  1.00 |         - |          NA |
| StructLinq | 5.332 μs | 0.0204 μs | 0.0160 μs |  1.49 |         - |          NA |
