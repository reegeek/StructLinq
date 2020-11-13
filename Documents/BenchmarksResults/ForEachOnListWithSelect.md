## ForEachOnListWithSelect

### Source
[ForEachOnListWithSelect.cs](../../src/StructLinq.Benchmark/ForEachOnListWithSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                               Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                                 LINQ | 73.30 μs | 0.543 μs | 0.508 μs |  1.00 |     - |     - |     - |      72 B |
|                   StructLinqWithFunc | 20.91 μs | 0.143 μs | 0.134 μs |  0.29 |     - |     - |     - |         - |
|       StructLinqWithFuncAsEnumerable | 66.68 μs | 0.387 μs | 0.362 μs |  0.91 |     - |     - |     - |      96 B |
|             StructLinqWithStructFunc | 13.36 μs | 0.046 μs | 0.043 μs |  0.18 |     - |     - |     - |         - |
| StructLinqWithStructFuncAsEnumerable | 53.55 μs | 0.234 μs | 0.195 μs |  0.73 |     - |     - |     - |      96 B |
