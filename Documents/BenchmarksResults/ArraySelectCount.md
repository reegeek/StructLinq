## ArraySelectCount

### Source
[ArraySelectCount.cs](../../src/StructLinq.Benchmark/ArraySelectCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
|                Linq | 21.26 us | 0.194 us | 0.182 us |     - |     - |     - |      48 B |
|          StructLinq | 14.12 us | 0.033 us | 0.031 us |     - |     - |     - |      32 B |
| StructLinqZeroAlloc | 13.85 us | 0.039 us | 0.036 us |     - |     - |     - |         - |
|         WithVisitor | 12.76 us | 0.059 us | 0.052 us |     - |     - |     - |         - |
