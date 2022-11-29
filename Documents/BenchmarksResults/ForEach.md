## ForEach

### Source
[ForEach.cs](../../src/StructLinq.Benchmark/ForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                      Method |      Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|---------------------------- |----------:|---------:|---------:|------:|----------:|------------:|
|                  ClrForEach | 353.44 μs | 1.817 μs | 1.610 μs |  1.00 |      40 B |        1.00 |
|                  WithAction | 176.35 μs | 0.661 μs | 0.619 μs |  0.50 |      24 B |        0.60 |
|                  WithStruct |  25.47 μs | 0.094 μs | 0.078 μs |  0.07 |      24 B |        0.60 |
|         ZeroAllocWithStruct | 137.62 μs | 0.493 μs | 0.461 μs |  0.39 |         - |        0.00 |
| ToTypedEnumerableWithStruct | 366.26 μs | 1.795 μs | 1.679 μs |  1.04 |      64 B |        1.60 |
