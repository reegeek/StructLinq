## ToListComparison

### Source
[ToListComparison.cs](../../src/StructLinq.Benchmark/ToListComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-ILXHKQ : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  Job-DKIKQP : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                      Method |       Runtime |     Mean |    Error |   StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |-------------- |---------:|---------:|---------:|--------:|-------:|------:|----------:|
|                   AddInList |      .NET 4.8 | 32.72 us | 0.088 us | 0.073 us | 31.1890 | 0.0610 |     - | 128.48 KB |
|          ToArrayThenNewList |      .NET 4.8 | 24.67 us | 0.045 us | 0.042 us | 19.0430 | 0.0305 |     - |  78.37 KB |
| ToArrayThenNewListAndLayout |      .NET 4.8 | 20.83 us | 0.039 us | 0.036 us |  9.5215 |      - |     - |  39.19 KB |
|                   AddInList | .NET Core 3.1 | 24.93 us | 0.099 us | 0.093 us | 31.2195 | 0.0916 |     - | 128.32 KB |
|          ToArrayThenNewList | .NET Core 3.1 | 25.29 us | 0.082 us | 0.073 us | 19.0430 | 3.7842 |     - |   78.2 KB |
| ToArrayThenNewListAndLayout | .NET Core 3.1 | 21.13 us | 0.100 us | 0.093 us |  9.5215 | 1.1902 |     - |  39.12 KB |
