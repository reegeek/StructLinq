## Zip

### Source
[Zip.cs](../../src/StructLinq.Benchmark/Zip.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|             Method |      Mean |     Error |    StdDev | Ratio | Allocated | Alloc Ratio |
|------------------- |----------:|----------:|----------:|------:|----------:|------------:|
|               Linq | 63.072 μs | 0.3200 μs | 0.2993 μs |  1.00 |     144 B |        1.00 |
|         StructLinq |  8.846 μs | 0.0417 μs | 0.0390 μs |  0.14 |      64 B |        0.44 |
| StructLinqFunction |  9.748 μs | 0.0364 μs | 0.0341 μs |  0.15 |         - |        0.00 |
