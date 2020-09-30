## OrderByArrayOfInt

### Source
[OrderByArrayOfInt.cs](../../src/StructLinq.Benchmark/OrderByArrayOfInt.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                     Method |       Mean |   Error |  StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|--------------------------- |-----------:|--------:|--------:|------:|--------:|-------:|------:|----------:|
|                       LINQ | 1,566.5 us | 2.23 us | 2.09 us |  1.00 | 27.3438 | 1.9531 |     - |  120411 B |
|            StructLinqOrder | 1,303.3 us | 3.91 us | 3.66 us |  0.83 |       - |      - |     - |      33 B |
|          StructLinqOrderBy | 1,367.9 us | 1.28 us | 1.13 us |  0.87 |       - |      - |     - |      35 B |
|   StructLinqOrderZeroAlloc |   917.9 us | 1.18 us | 1.10 us |  0.59 |       - |      - |     - |       1 B |
| StructLinqOrderByZeroAlloc |   944.9 us | 1.34 us | 1.26 us |  0.60 |       - |      - |     - |       4 B |
