## ToListComparison

### Source
[ToListComparison.cs](../../src/StructLinq.Benchmark/ToListComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.403
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-WBFIAX : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  Job-CJLCJU : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                      Method |       Runtime |     Mean |    Error |   StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |-------------- |---------:|---------:|---------:|--------:|-------:|------:|----------:|
|                   AddInList |      .NET 4.8 | 42.58 us | 1.468 us | 1.442 us | 31.1890 | 7.7515 |     - | 128.48 KB |
|          ToArrayThenNewList |      .NET 4.8 | 36.02 us | 0.553 us | 0.490 us | 19.0430 | 0.0610 |     - |  78.37 KB |
| ToArrayThenNewListAndLayout |      .NET 4.8 | 30.61 us | 0.596 us | 0.796 us |  9.5215 |      - |     - |  39.19 KB |
|                 WithVisitor |      .NET 4.8 | 24.45 us | 0.314 us | 0.278 us |  9.5215 |      - |     - |  39.19 KB |
|                   AddInList | .NET Core 3.1 | 29.41 us | 0.579 us | 0.513 us | 31.1890 | 7.7515 |     - | 128.32 KB |
|          ToArrayThenNewList | .NET Core 3.1 | 35.14 us | 0.530 us | 0.443 us | 19.0430 | 3.7842 |     - |   78.2 KB |
| ToArrayThenNewListAndLayout | .NET Core 3.1 | 30.15 us | 0.451 us | 0.422 us |  9.5215 | 1.1902 |     - |  39.12 KB |
|                 WithVisitor | .NET Core 3.1 | 24.83 us | 0.493 us | 0.658 us |  9.5215 | 1.1902 |     - |  39.12 KB |
