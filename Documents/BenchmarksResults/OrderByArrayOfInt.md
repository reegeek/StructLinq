## OrderByArrayOfInt

### Source
[OrderByArrayOfInt.cs](../../src/StructLinq.Benchmark/OrderByArrayOfInt.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                     Method |       Mean |   Error |  StdDev | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|--------------------------- |-----------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
|                       LINQ | 1,288.7 μs | 3.98 μs | 3.73 μs |  1.00 | 25.3906 | 3.9063 |  120313 B |       1.000 |
|            StructLinqOrder | 1,434.2 μs | 4.27 μs | 3.79 μs |  1.11 |       - |      - |      34 B |       0.000 |
|          StructLinqOrderBy | 1,456.8 μs | 6.77 μs | 6.33 μs |  1.13 |       - |      - |      34 B |       0.000 |
|   StructLinqOrderZeroAlloc |   888.1 μs | 2.12 μs | 1.88 μs |  0.69 |       - |      - |       1 B |       0.000 |
| StructLinqOrderByZeroAlloc |   893.2 μs | 2.54 μs | 2.38 μs |  0.69 |       - |      - |       1 B |       0.000 |
