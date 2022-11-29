## ForEachOnList

### Source
[ForEachOnList.cs](../../src/StructLinq.Benchmark/ForEachOnList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|     Method |      Mean |     Error |    StdDev | Ratio | Allocated | Alloc Ratio |
|----------- |----------:|----------:|----------:|------:|----------:|------------:|
|    Default | 10.101 μs | 0.0631 μs | 0.0560 μs |  1.00 |         - |          NA |
| StructLinq |  3.580 μs | 0.0130 μs | 0.0122 μs |  0.35 |         - |          NA |
