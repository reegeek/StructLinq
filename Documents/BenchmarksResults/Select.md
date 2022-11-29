## Select

### Source
[Select.cs](../../src/StructLinq.Benchmark/Select.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|         Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|--------------- |---------:|---------:|---------:|------:|----------:|------------:|
|      SysSelect | 55.23 μs | 0.216 μs | 0.202 μs |  1.00 |      88 B |        1.00 |
| DelegateSelect | 20.19 μs | 0.078 μs | 0.073 μs |  0.37 |      56 B |        0.64 |
|   StructSelect | 10.05 μs | 0.036 μs | 0.032 μs |  0.18 |         - |        0.00 |
|  ConvertSelect | 40.37 μs | 0.145 μs | 0.128 μs |  0.73 |      40 B |        0.45 |
