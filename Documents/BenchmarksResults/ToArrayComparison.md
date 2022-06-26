## ToArrayComparison

### Source
[ToArrayComparison.cs](../../src/StructLinq.Benchmark/ToArrayComparison.cs)

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
|                  Method |                Job |            Runtime |      Mean |     Error |    StdDev | Ratio |   Gen 0 |  Gen 1 | Allocated |
|------------------------ |------------------- |------------------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|
|       ToListThenToArray |           .NET 5.0 |           .NET 5.0 | 23.627 μs | 0.2010 μs | 0.1881 μs |  0.75 | 36.1328 | 0.0305 |    167 KB |
|       ToListThenToArray |           .NET 6.0 |           .NET 6.0 | 23.482 μs | 0.2869 μs | 0.2684 μs |  0.75 | 36.1328 | 0.0305 |    167 KB |
|       ToListThenToArray | .NET Framework 4.8 | .NET Framework 4.8 | 31.394 μs | 0.1834 μs | 0.1626 μs |  1.00 | 36.1328 | 0.0610 |    168 KB |
|                         |                    |                    |           |           |           |       |         |        |           |
| ToPooledListThenToArray |           .NET 5.0 |           .NET 5.0 | 17.603 μs | 0.1357 μs | 0.1269 μs |  0.92 |  8.4534 | 1.0376 |     39 KB |
| ToPooledListThenToArray |           .NET 6.0 |           .NET 6.0 | 19.285 μs | 0.1157 μs | 0.1082 μs |  1.01 |  8.4534 | 1.0376 |     39 KB |
| ToPooledListThenToArray | .NET Framework 4.8 | .NET Framework 4.8 | 19.129 μs | 0.2405 μs | 0.2250 μs |  1.00 |  8.4534 | 1.0376 |     39 KB |
|                         |                    |                    |           |           |           |       |         |        |           |
|      UseCountForToArray |           .NET 5.0 |           .NET 5.0 |  6.463 μs | 0.0747 μs | 0.0662 μs |  0.55 |  8.4686 | 1.0529 |     39 KB |
|      UseCountForToArray |           .NET 6.0 |           .NET 6.0 |  6.441 μs | 0.0543 μs | 0.0508 μs |  0.55 |  8.4686 | 1.0529 |     39 KB |
|      UseCountForToArray | .NET Framework 4.8 | .NET Framework 4.8 | 11.804 μs | 0.0995 μs | 0.0931 μs |  1.00 |  8.4686 | 1.0529 |     39 KB |
|                         |                    |                    |           |           |           |       |         |        |           |
|       StructLinqToArray |           .NET 5.0 |           .NET 5.0 |  5.587 μs | 0.0480 μs | 0.0449 μs |  0.87 |  8.4686 | 1.0529 |     39 KB |
|       StructLinqToArray |           .NET 6.0 |           .NET 6.0 |  5.193 μs | 0.0385 μs | 0.0360 μs |  0.81 |  8.4686 | 1.0529 |     39 KB |
|       StructLinqToArray | .NET Framework 4.8 | .NET Framework 4.8 |  6.424 μs | 0.0645 μs | 0.0603 μs |  1.00 |  8.4686 | 1.0529 |     39 KB |
