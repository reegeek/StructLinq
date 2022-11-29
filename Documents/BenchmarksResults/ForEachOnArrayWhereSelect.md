## ForEachOnArrayWhereSelect

### Source
[ForEachOnArrayWhereSelect.cs](../../src/StructLinq.Benchmark/ForEachOnArrayWhereSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                             Method |     Mean |    Error |   StdDev | Allocated |
|----------------------------------- |---------:|---------:|---------:|----------:|
|                            SysLinq | 49.25 μs | 0.138 μs | 0.122 μs |     104 B |
|             StructLinqWithDelegate | 34.00 μs | 0.185 μs | 0.155 μs |         - |
| StructLinqWithDelegateAsEnumerable | 44.51 μs | 0.240 μs | 0.213 μs |     104 B |
|                         StructLinq | 13.66 μs | 0.063 μs | 0.052 μs |         - |
|             StructLinqAsEnumerable | 26.15 μs | 0.270 μs | 0.252 μs |     104 B |
