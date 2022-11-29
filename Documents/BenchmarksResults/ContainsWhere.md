## ContainsWhere

### Source
[ContainsWhere.cs](../../src/StructLinq.Benchmark/ContainsWhere.cs)

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
|                Linq | 31.58 μs | 0.121 μs | 0.113 μs |  1.00 |      48 B |        1.00 |
|               Array | 31.59 μs | 0.152 μs | 0.135 μs |  1.00 |      48 B |        1.00 |
|          StructLinq | 10.12 μs | 0.047 μs | 0.042 μs |  0.32 |      64 B |        1.33 |
| StructLinqZeroAlloc | 10.12 μs | 0.043 μs | 0.036 μs |  0.32 |         - |        0.00 |
