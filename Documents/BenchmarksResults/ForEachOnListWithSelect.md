## ForEachOnListWithSelect

### Source
[ForEachOnListWithSelect.cs](../../src/StructLinq.Benchmark/ForEachOnListWithSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                               Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                                 LINQ | 73.22 us | 0.177 us | 0.157 us |  1.00 |     - |     - |     - |      73 B |
|                   StructLinqWithFunc | 28.17 us | 0.034 us | 0.032 us |  0.38 |     - |     - |     - |         - |
|       StructLinqWithFuncAsEnumerable | 79.16 us | 0.128 us | 0.113 us |  1.08 |     - |     - |     - |      88 B |
|             StructLinqWithStructFunc | 14.98 us | 0.019 us | 0.018 us |  0.20 |     - |     - |     - |         - |
| StructLinqWithStructFuncAsEnumerable | 64.86 us | 0.139 us | 0.130 us |  0.89 |     - |     - |     - |      89 B |
