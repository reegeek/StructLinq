## ToArrayComparison

### Source
[ToArrayComparison.cs](../../src/StructLinq.Benchmark/ToArrayComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]        : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                  Method |           Job |       Runtime |      Mean |     Error |    StdDev | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------ |-------------- |-------------- |----------:|----------:|----------:|----------:|--------:|-------:|------:|----------:|
|       ToListThenToArray |      .NET 4.8 |      .NET 4.8 | 33.230 μs | 0.3353 μs | 0.2972 μs |   0.58 KB | 36.1328 |      - |     - | 167.59 KB |
| ToPooledListThenToArray |      .NET 4.8 |      .NET 4.8 | 18.844 μs | 0.3548 μs | 0.3796 μs |   1.56 KB |  8.4534 | 0.0305 |     - |  39.11 KB |
|      UseCountForToArray |      .NET 4.8 |      .NET 4.8 | 11.251 μs | 0.0773 μs | 0.0723 μs |   0.09 KB |  8.4686 | 0.0153 |     - |  39.11 KB |
|       StructLinqToArray |      .NET 4.8 |      .NET 4.8 |  6.066 μs | 0.0157 μs | 0.0122 μs |   0.45 KB |  8.4686 | 0.0076 |     - |  39.11 KB |
|       ToListThenToArray | .NET Core 5.0 | .NET Core 5.0 | 22.805 μs | 0.1764 μs | 0.1650 μs |   1.33 KB | 36.1328 | 0.0305 |     - | 167.41 KB |
| ToPooledListThenToArray | .NET Core 5.0 | .NET Core 5.0 | 17.015 μs | 0.0669 μs | 0.0593 μs |   1.35 KB |  8.4534 | 1.0376 |     - |  39.09 KB |
|      UseCountForToArray | .NET Core 5.0 | .NET Core 5.0 |  5.552 μs | 0.0181 μs | 0.0170 μs |   0.09 KB |  8.4686 | 1.0529 |     - |  39.09 KB |
|       StructLinqToArray | .NET Core 5.0 | .NET Core 5.0 |  4.978 μs | 0.0164 μs | 0.0153 μs |   0.32 KB |  8.4686 | 1.0529 |     - |  39.09 KB |
