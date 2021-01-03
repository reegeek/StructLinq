## OrderByArrayOfInt

### Source
[OrderByArrayOfInt.cs](../../src/StructLinq.Benchmark/OrderByArrayOfInt.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                     Method |       Mean |   Error |  StdDev | Ratio | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|--------------------------- |-----------:|--------:|--------:|------:|----------:|--------:|-------:|------:|----------:|
|                       LINQ | 1,390.4 μs | 5.64 μs | 5.00 μs |  1.00 |     524 B | 25.3906 | 3.9063 |     - |  120312 B |
|            StructLinqOrder | 1,447.7 μs | 6.23 μs | 5.83 μs |  1.04 |    3952 B |       - |      - |     - |      33 B |
|          StructLinqOrderBy | 1,448.5 μs | 5.70 μs | 5.33 μs |  1.04 |    4272 B |       - |      - |     - |      33 B |
|   StructLinqOrderZeroAlloc |   927.5 μs | 3.62 μs | 3.39 μs |  0.67 |    3350 B |       - |      - |     - |         - |
| StructLinqOrderByZeroAlloc |   944.7 μs | 3.32 μs | 3.11 μs |  0.68 |    3756 B |       - |      - |     - |         - |
