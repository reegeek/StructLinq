## ToListOnArrayWhere

### Source
[ToListOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToListOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|             Linq | 35.54 us | 0.138 us | 0.129 us |  1.00 | 15.6860 | 0.1221 |     - |  64.34 KB |
|       StructLinq | 41.27 us | 0.137 us | 0.128 us |  1.16 |  4.7607 |      - |     - |  19.65 KB |
| StructLinqFaster | 23.34 us | 0.056 us | 0.053 us |  0.66 |  4.7607 |      - |     - |  19.59 KB |
