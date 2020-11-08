## ListWhereSelectSum

### Source
[ListWhereSelectSum.cs](../../src/StructLinq.Benchmark/ListWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|                            LINQ | 68.016 us | 0.5956 us | 0.5571 us |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 76.824 us | 0.5311 us | 0.4708 us |  1.13 |     - |     - |     - |     104 B |
| StructLinqWithDelegateZeroAlloc | 42.900 us | 0.2142 us | 0.2004 us |  0.63 |     - |     - |     - |         - |
|             StructLinqZeroAlloc |  9.161 us | 0.0628 us | 0.0588 us |  0.13 |     - |     - |     - |         - |
