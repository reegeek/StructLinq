## ImpactOfUsingOnForEach

### Source
[ImpactOfUsingOnForEach.cs](../../src/StructLinq.Benchmark/ImpactOfUsingOnForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]             : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET 6.0           : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256


```
|                        Method |                Job |            Runtime |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------ |------------------- |------------------- |----------:|----------:|----------:|------:|--------:|
|      ForEachWithUsingOnStruct |           .NET 6.0 |           .NET 6.0 |  2.541 μs | 0.0168 μs | 0.0149 μs |  0.50 |    0.01 |
|   ForEachWithoutUsingOnStruct |           .NET 6.0 |           .NET 6.0 |  2.536 μs | 0.0074 μs | 0.0066 μs |  0.50 |    0.00 |
| ForEachWithTryFinallyOnStruct |           .NET 6.0 |           .NET 6.0 |  2.531 μs | 0.0075 μs | 0.0070 μs |  0.50 |    0.00 |
|       ForEachWithUsingOnClass |           .NET 6.0 |           .NET 6.0 | 37.037 μs | 0.1291 μs | 0.1208 μs |  7.35 |    0.07 |
|    ForEachWithoutUsingOnClass |           .NET 6.0 |           .NET 6.0 |  2.540 μs | 0.0178 μs | 0.0148 μs |  0.50 |    0.00 |
|  ForEachWithTryFinallyOnClass |           .NET 6.0 |           .NET 6.0 | 35.780 μs | 0.2242 μs | 0.2097 μs |  7.10 |    0.08 |
|      ForEachWithUsingOnStruct |           .NET 7.0 |           .NET 7.0 |  2.533 μs | 0.0092 μs | 0.0086 μs |  0.50 |    0.00 |
|   ForEachWithoutUsingOnStruct |           .NET 7.0 |           .NET 7.0 |  2.529 μs | 0.0103 μs | 0.0096 μs |  0.50 |    0.00 |
| ForEachWithTryFinallyOnStruct |           .NET 7.0 |           .NET 7.0 |  2.543 μs | 0.0216 μs | 0.0202 μs |  0.50 |    0.01 |
|       ForEachWithUsingOnClass |           .NET 7.0 |           .NET 7.0 | 35.306 μs | 0.1201 μs | 0.1065 μs |  7.00 |    0.06 |
|    ForEachWithoutUsingOnClass |           .NET 7.0 |           .NET 7.0 |  2.529 μs | 0.0116 μs | 0.0109 μs |  0.50 |    0.01 |
|  ForEachWithTryFinallyOnClass |           .NET 7.0 |           .NET 7.0 | 35.306 μs | 0.1707 μs | 0.1597 μs |  7.00 |    0.06 |
|      ForEachWithUsingOnStruct | .NET Framework 4.8 | .NET Framework 4.8 |  5.041 μs | 0.0498 μs | 0.0416 μs |  1.00 |    0.00 |
|   ForEachWithoutUsingOnStruct | .NET Framework 4.8 | .NET Framework 4.8 |  2.528 μs | 0.0106 μs | 0.0099 μs |  0.50 |    0.01 |
| ForEachWithTryFinallyOnStruct | .NET Framework 4.8 | .NET Framework 4.8 |  5.040 μs | 0.0218 μs | 0.0204 μs |  1.00 |    0.01 |
|       ForEachWithUsingOnClass | .NET Framework 4.8 | .NET Framework 4.8 | 25.131 μs | 0.1195 μs | 0.1118 μs |  4.99 |    0.04 |
|    ForEachWithoutUsingOnClass | .NET Framework 4.8 | .NET Framework 4.8 | 13.374 μs | 0.0458 μs | 0.0428 μs |  2.65 |    0.02 |
|  ForEachWithTryFinallyOnClass | .NET Framework 4.8 | .NET Framework 4.8 | 25.168 μs | 0.0722 μs | 0.0675 μs |  4.99 |    0.04 |
