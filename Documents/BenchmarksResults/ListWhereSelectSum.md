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
|                 Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                   LINQ | 71.73 us | 0.146 us | 0.129 us |  1.00 |     - |     - |     - |     152 B |
| StructLinqWithDelegate | 45.02 us | 0.025 us | 0.022 us |  0.63 |     - |     - |     - |     104 B |
|    StructLinqZeroAlloc | 15.63 us | 0.132 us | 0.123 us |  0.22 |     - |     - |     - |         - |
