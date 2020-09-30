## Aggregate

### Source
[Aggregate.cs](../../src/StructLinq.Benchmark/Aggregate.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                   Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|             SysAggregate | 56.222 us | 0.1176 us | 0.1100 us |  1.00 |     - |     - |     - |      40 B |
|        DelegateAggregate | 30.932 us | 0.0806 us | 0.0714 us |  0.55 |     - |     - |     - |      24 B |
|          StructAggregate |  5.637 us | 0.0097 us | 0.0091 us |  0.10 |     - |     - |     - |      24 B |
| ZeroAllocStructAggregate | 15.053 us | 0.0089 us | 0.0074 us |  0.27 |     - |     - |     - |         - |
|         ConvertAggregate | 39.362 us | 0.0762 us | 0.0637 us |  0.70 |     - |     - |     - |      64 B |
