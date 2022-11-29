## SelectOnArrayOfClass

### Source
[SelectOnArrayOfClass.cs](../../src/StructLinq.Benchmark/SelectOnArrayOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|              Handmaded |  5.886 μs | 0.0315 μs | 0.0295 μs |  1.00 |    0.00 |         - |          NA |
|                   LINQ | 55.873 μs | 0.1773 μs | 0.1658 μs |  9.49 |    0.04 |      48 B |          NA |
|             StructLINQ | 20.447 μs | 0.0825 μs | 0.0644 μs |  3.48 |    0.02 |         - |          NA |
| StructLINQWithFunction | 13.377 μs | 0.0264 μs | 0.0234 μs |  2.27 |    0.01 |         - |          NA |
