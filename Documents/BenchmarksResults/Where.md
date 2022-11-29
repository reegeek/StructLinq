## Where

### Source
[Where.cs](../../src/StructLinq.Benchmark/Where.cs)

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
|      SysSelect | 97.16 μs | 0.752 μs | 0.628 μs |  1.00 |      96 B |        1.00 |
| DelegateSelect | 17.70 μs | 0.045 μs | 0.040 μs |  0.18 |      56 B |        0.58 |
|   StructSelect | 13.60 μs | 0.030 μs | 0.027 μs |  0.14 |         - |        0.00 |
|  ConvertSelect | 40.36 μs | 0.155 μs | 0.145 μs |  0.42 |      40 B |        0.42 |
