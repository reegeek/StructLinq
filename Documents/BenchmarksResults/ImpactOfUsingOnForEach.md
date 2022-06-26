## ImpactOfUsingOnForEach

### Source
[ImpactOfUsingOnForEach.cs](../../src/StructLinq.Benchmark/ImpactOfUsingOnForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]             : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET 5.0           : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0           : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT


```
|                        Method |                Job |            Runtime |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------ |------------------- |------------------- |----------:|----------:|----------:|------:|--------:|
|      ForEachWithUsingOnStruct |           .NET 5.0 |           .NET 5.0 |  5.192 μs | 0.0478 μs | 0.0447 μs |  1.01 |    0.01 |
|   ForEachWithoutUsingOnStruct |           .NET 5.0 |           .NET 5.0 |  5.148 μs | 0.0417 μs | 0.0390 μs |  1.00 |    0.01 |
| ForEachWithTryFinallyOnStruct |           .NET 5.0 |           .NET 5.0 |  5.157 μs | 0.0365 μs | 0.0324 μs |  1.00 |    0.01 |
|       ForEachWithUsingOnClass |           .NET 5.0 |           .NET 5.0 | 40.667 μs | 0.3029 μs | 0.2685 μs |  7.88 |    0.07 |
|    ForEachWithoutUsingOnClass |           .NET 5.0 |           .NET 5.0 |  5.133 μs | 0.0281 μs | 0.0249 μs |  0.99 |    0.01 |
|  ForEachWithTryFinallyOnClass |           .NET 5.0 |           .NET 5.0 | 40.571 μs | 0.2387 μs | 0.2232 μs |  7.86 |    0.07 |
|      ForEachWithUsingOnStruct |           .NET 6.0 |           .NET 6.0 |  2.583 μs | 0.0179 μs | 0.0149 μs |  0.50 |    0.00 |
|   ForEachWithoutUsingOnStruct |           .NET 6.0 |           .NET 6.0 |  2.597 μs | 0.0233 μs | 0.0218 μs |  0.50 |    0.01 |
| ForEachWithTryFinallyOnStruct |           .NET 6.0 |           .NET 6.0 |  2.596 μs | 0.0370 μs | 0.0346 μs |  0.50 |    0.01 |
|       ForEachWithUsingOnClass |           .NET 6.0 |           .NET 6.0 | 25.710 μs | 0.1644 μs | 0.1538 μs |  4.98 |    0.04 |
|    ForEachWithoutUsingOnClass |           .NET 6.0 |           .NET 6.0 |  2.583 μs | 0.0195 μs | 0.0163 μs |  0.50 |    0.00 |
|  ForEachWithTryFinallyOnClass |           .NET 6.0 |           .NET 6.0 | 25.690 μs | 0.2591 μs | 0.2424 μs |  4.98 |    0.05 |
|      ForEachWithUsingOnStruct | .NET Framework 4.8 | .NET Framework 4.8 |  5.161 μs | 0.0325 μs | 0.0304 μs |  1.00 |    0.00 |
|   ForEachWithoutUsingOnStruct | .NET Framework 4.8 | .NET Framework 4.8 |  2.570 μs | 0.0116 μs | 0.0097 μs |  0.50 |    0.00 |
| ForEachWithTryFinallyOnStruct | .NET Framework 4.8 | .NET Framework 4.8 |  5.173 μs | 0.0442 μs | 0.0413 μs |  1.00 |    0.01 |
|       ForEachWithUsingOnClass | .NET Framework 4.8 | .NET Framework 4.8 | 32.562 μs | 0.2317 μs | 0.2054 μs |  6.31 |    0.06 |
|    ForEachWithoutUsingOnClass | .NET Framework 4.8 | .NET Framework 4.8 | 13.429 μs | 0.0744 μs | 0.0696 μs |  2.60 |    0.02 |
|  ForEachWithTryFinallyOnClass | .NET Framework 4.8 | .NET Framework 4.8 | 32.659 μs | 0.3923 μs | 0.3669 μs |  6.33 |    0.08 |
