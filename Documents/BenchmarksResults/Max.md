## Max

### Source
[Max.cs](../../src/StructLinq.Benchmark/Max.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Allocated |
|-------------------------------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|
|                       Handmaded |  2.609 μs | 0.0156 μs | 0.0139 μs |  1.00 |    0.00 |      - |         - |
|                            LINQ | 38.910 μs | 0.2739 μs | 0.2562 μs | 14.92 |    0.14 |      - |      40 B |
|                      StructLINQ |  3.453 μs | 0.0201 μs | 0.0178 μs |  1.32 |    0.01 | 0.0038 |      24 B |
|             ZeroAllocStructLINQ |  3.434 μs | 0.0300 μs | 0.0266 μs |  1.32 |    0.01 |      - |         - |
| ZeroAllocStructLINQOnEnumerable |  4.550 μs | 0.0876 μs | 0.1256 μs |  1.75 |    0.06 |      - |         - |
|                      ConvertMin | 39.008 μs | 0.2959 μs | 0.2767 μs | 14.95 |    0.17 |      - |      64 B |
