## ListWhereSelectSum

### Source
[ListWhereSelectSum.cs](../../src/StructLinq.Benchmark/ListWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                          Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                            LINQ | 78.19 us | 1.615 us | 1.432 us |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 45.97 us | 0.469 us | 0.439 us |  0.59 |     - |     - |     - |     104 B |
| StructLinqWithDelegateZeroAlloc | 44.63 us | 0.411 us | 0.385 us |  0.57 |     - |     - |     - |         - |
|             StructLinqZeroAlloc | 15.22 us | 0.031 us | 0.028 us |  0.19 |     - |     - |     - |         - |
