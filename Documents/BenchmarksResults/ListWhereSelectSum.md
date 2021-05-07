## ListWhereSelectSum

### Source
[ListWhereSelectSum.cs](../../src/StructLinq.Benchmark/ListWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                          Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                            LINQ | 76.56 μs | 0.593 μs | 1.099 μs |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 66.34 μs | 0.210 μs | 0.175 μs |  0.87 |     - |     - |     - |      96 B |
| StructLinqWithDelegateZeroAlloc | 31.70 μs | 0.241 μs | 0.214 μs |  0.41 |     - |     - |     - |         - |
|             StructLinqZeroAlloc | 12.69 μs | 0.024 μs | 0.020 μs |  0.17 |     - |     - |     - |         - |
