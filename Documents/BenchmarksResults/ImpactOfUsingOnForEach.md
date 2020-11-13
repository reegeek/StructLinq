## ImpactOfUsingOnForEach

### Source
[ImpactOfUsingOnForEach.cs](../../src/StructLinq.Benchmark/ImpactOfUsingOnForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-ILXHKQ : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  Job-DKIKQP : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                        Method |       Runtime |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------ |-------------- |----------:|----------:|----------:|------:|--------:|
|      ForEachWithUsingOnStruct |      .NET 4.8 |  2.827 us | 0.0047 us | 0.0044 us |  1.00 |    0.00 |
|   ForEachWithoutUsingOnStruct |      .NET 4.8 |  2.830 us | 0.0051 us | 0.0047 us |  1.00 |    0.00 |
| ForEachWithTryFinallyOnStruct |      .NET 4.8 |  2.825 us | 0.0042 us | 0.0040 us |  1.00 |    0.00 |
|       ForEachWithUsingOnClass |      .NET 4.8 | 30.887 us | 0.0653 us | 0.0611 us | 10.93 |    0.03 |
|    ForEachWithoutUsingOnClass |      .NET 4.8 | 14.860 us | 0.0121 us | 0.0113 us |  5.26 |    0.01 |
|  ForEachWithTryFinallyOnClass |      .NET 4.8 | 30.897 us | 0.0442 us | 0.0414 us | 10.93 |    0.02 |
|                               |               |           |           |           |       |         |
|      ForEachWithUsingOnStruct | .NET Core 3.1 |  2.825 us | 0.0049 us | 0.0046 us |  1.00 |    0.00 |
|   ForEachWithoutUsingOnStruct | .NET Core 3.1 |  2.826 us | 0.0057 us | 0.0054 us |  1.00 |    0.00 |
| ForEachWithTryFinallyOnStruct | .NET Core 3.1 |  2.827 us | 0.0069 us | 0.0064 us |  1.00 |    0.00 |
|       ForEachWithUsingOnClass | .NET Core 3.1 | 28.087 us | 0.0307 us | 0.0272 us |  9.94 |    0.02 |
|    ForEachWithoutUsingOnClass | .NET Core 3.1 | 14.930 us | 0.0457 us | 0.0428 us |  5.29 |    0.01 |
|  ForEachWithTryFinallyOnClass | .NET Core 3.1 | 28.085 us | 0.0325 us | 0.0304 us |  9.94 |    0.01 |
