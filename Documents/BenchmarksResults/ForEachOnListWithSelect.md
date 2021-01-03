## ForEachOnListWithSelect

### Source
[ForEachOnListWithSelect.cs](../../src/StructLinq.Benchmark/ForEachOnListWithSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                               Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
|                                 LINQ | 75.10 μs | 1.442 μs | 1.603 μs |  1.00 |    0.00 |     - |     - |     - |      72 B |
|                   StructLinqWithFunc | 17.94 μs | 0.059 μs | 0.053 μs |  0.24 |    0.01 |     - |     - |     - |         - |
|       StructLinqWithFuncAsEnumerable | 57.31 μs | 0.144 μs | 0.128 μs |  0.76 |    0.02 |     - |     - |     - |      88 B |
|             StructLinqWithStructFunc | 13.26 μs | 0.033 μs | 0.030 μs |  0.18 |    0.00 |     - |     - |     - |         - |
| StructLinqWithStructFuncAsEnumerable | 53.18 μs | 0.172 μs | 0.161 μs |  0.71 |    0.02 |     - |     - |     - |      88 B |
