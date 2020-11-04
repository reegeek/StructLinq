## SumOnList

### Source
[SumOnList.cs](../../src/StructLinq.Benchmark/SumOnList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|     Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|       Linq | 66.323 us | 0.9057 us | 0.8472 us |  1.00 |     - |     - |     - |      41 B |
| StructLinq |  5.417 us | 0.1071 us | 0.1233 us |  0.08 |     - |     - |     - |         - |
|  WithVisit |  5.253 us | 0.0333 us | 0.0312 us |  0.08 |     - |     - |     - |         - |
