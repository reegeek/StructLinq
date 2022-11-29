## IList

### Source
[IList.cs](../../src/StructLinq.Benchmark/IList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|     Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|----------- |---------:|---------:|---------:|------:|----------:|------------:|
|       Linq | 65.66 μs | 0.215 μs | 0.201 μs |  1.00 |      40 B |        1.00 |
| StructLinq | 22.73 μs | 0.061 μs | 0.057 μs |  0.35 |         - |        0.00 |
