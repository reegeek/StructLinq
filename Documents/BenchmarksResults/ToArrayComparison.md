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
|       ToListThenToArray |      .NET 4.8 |      .NET 4.8 | 29.983 μs | 0.1955 μs | 0.1829 μs |   0.58 KB | 36.1328 |      - |     - | 167.59 KB |
| ToPooledListThenToArray |      .NET 4.8 |      .NET 4.8 | 17.976 μs | 0.1138 μs | 0.1065 μs |   1.56 KB |  8.4534 | 0.0305 |     - |  39.11 KB |
|      UseCountForToArray |      .NET 4.8 |      .NET 4.8 |  6.248 μs | 0.0391 μs | 0.0366 μs |   0.09 KB |  8.4686 | 0.0076 |     - |  39.11 KB |
|       StructLinqToArray |      .NET 4.8 |      .NET 4.8 |  5.788 μs | 0.0217 μs | 0.0203 μs |   0.45 KB |  8.4686 | 0.0076 |     - |  39.11 KB |
|       ToListThenToArray | .NET Core 5.0 | .NET Core 5.0 | 22.911 μs | 0.1639 μs | 0.1533 μs |   1.33 KB | 36.1328 | 0.0305 |     - | 167.41 KB |
| ToPooledListThenToArray | .NET Core 5.0 | .NET Core 5.0 | 19.488 μs | 0.0558 μs | 0.0522 μs |   1.26 KB |  8.4534 | 1.0376 |     - |  39.09 KB |
|      UseCountForToArray | .NET Core 5.0 | .NET Core 5.0 |  6.230 μs | 0.0173 μs | 0.0153 μs |   0.09 KB |  8.4686 | 1.0529 |     - |  39.09 KB |
|       StructLinqToArray | .NET Core 5.0 | .NET Core 5.0 |  5.886 μs | 0.0441 μs | 0.0412 μs |   0.23 KB |  8.4686 | 1.0529 |     - |  39.09 KB |
