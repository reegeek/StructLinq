## Concat

### Source
[Concat.cs](../../src/StructLinq.Benchmark/Concat.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|              Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|-------------------- |---------:|---------:|---------:|------:|----------:|------------:|
|                Linq | 75.90 μs | 0.262 μs | 0.245 μs |  1.00 |     120 B |        1.00 |
|          StructLinq | 18.79 μs | 0.268 μs | 0.251 μs |  0.25 |      64 B |        0.53 |
| StructLinqZeroAlloc | 14.24 μs | 0.043 μs | 0.036 μs |  0.19 |         - |        0.00 |
