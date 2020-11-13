## OrderByArrayOfInt

### Source
[OrderByArrayOfInt.cs](../../src/StructLinq.Benchmark/OrderByArrayOfInt.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                     Method |       Mean |   Error |  StdDev | Ratio | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|--------------------------- |-----------:|--------:|--------:|------:|----------:|--------:|-------:|------:|----------:|
|                       LINQ | 1,414.3 μs | 6.29 μs | 5.88 μs |  1.00 |     524 B | 25.3906 | 3.9063 |     - |  120312 B |
|            StructLinqOrder | 1,436.5 μs | 3.15 μs | 2.95 μs |  1.02 |    3952 B |       - |      - |     - |      33 B |
|          StructLinqOrderBy | 1,460.7 μs | 8.20 μs | 7.27 μs |  1.03 |    4272 B |       - |      - |     - |      33 B |
|   StructLinqOrderZeroAlloc |   952.6 μs | 3.49 μs | 3.27 μs |  0.67 |    3350 B |       - |      - |     - |         - |
| StructLinqOrderByZeroAlloc |   955.0 μs | 2.53 μs | 2.25 μs |  0.68 |    3756 B |       - |      - |     - |         - |
