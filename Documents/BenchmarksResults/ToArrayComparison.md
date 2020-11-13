## ToArrayComparison

### Source
[ToArrayComparison.cs](../../src/StructLinq.Benchmark/ToArrayComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                  Method |           Job |       Runtime |      Mean |     Error |    StdDev | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------ |-------------- |-------------- |----------:|----------:|----------:|----------:|--------:|-------:|------:|----------:|
|       ToListThenToArray |      .NET 4.8 |      .NET 4.8 | 32.320 μs | 0.6448 μs | 0.9248 μs |   0.58 KB | 36.1328 |      - |     - | 167.59 KB |
| ToPooledListThenToArray |      .NET 4.8 |      .NET 4.8 | 19.126 μs | 0.1244 μs | 0.1103 μs |   1.55 KB |  8.4534 | 0.0305 |     - |  39.11 KB |
|      UseCountForToArray |      .NET 4.8 |      .NET 4.8 |  6.763 μs | 0.1346 μs | 0.1887 μs |   0.08 KB |  8.4686 | 0.0076 |     - |  39.11 KB |
|       StructLinqToArray |      .NET 4.8 |      .NET 4.8 |  6.868 μs | 0.1361 μs | 0.2929 μs |    0.4 KB |  8.4686 | 0.0076 |     - |  39.11 KB |
|       ToListThenToArray | .NET Core 5.0 | .NET Core 5.0 | 24.590 μs | 0.4813 μs | 0.9156 μs |   1.32 KB | 36.1328 | 0.0305 |     - | 167.41 KB |
| ToPooledListThenToArray | .NET Core 5.0 | .NET Core 5.0 | 18.940 μs | 0.2498 μs | 0.2337 μs |   1.25 KB |  8.4534 | 1.0376 |     - |  39.09 KB |
|      UseCountForToArray | .NET Core 5.0 | .NET Core 5.0 |  6.558 μs | 0.0357 μs | 0.0334 μs |   0.09 KB |  8.4686 | 1.0529 |     - |  39.09 KB |
|       StructLinqToArray | .NET Core 5.0 | .NET Core 5.0 |  6.599 μs | 0.0913 μs | 0.0854 μs |   0.19 KB |  8.4686 | 1.0529 |     - |  39.09 KB |
