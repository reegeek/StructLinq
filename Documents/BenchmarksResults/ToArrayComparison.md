## ToArrayComparison

### Source
[ToArrayComparison.cs](../../src/StructLinq.Benchmark/ToArrayComparison.cs)

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
|                  Method |                Job |            Runtime |      Mean |     Error |    StdDev | Ratio |    Gen0 |    Gen1 | Allocated | Alloc Ratio |
|------------------------ |------------------- |------------------- |----------:|----------:|----------:|------:|--------:|--------:|----------:|------------:|
|       ToListThenToArray |           .NET 6.0 |           .NET 6.0 | 22.776 μs | 0.1531 μs | 0.1432 μs |  0.75 | 36.1328 |  0.0305 | 167.41 KB |        1.00 |
|       ToListThenToArray |           .NET 7.0 |           .NET 7.0 | 24.529 μs | 0.1084 μs | 0.0961 μs |  0.81 | 36.1328 | 12.0239 | 167.41 KB |        1.00 |
|       ToListThenToArray | .NET Framework 4.8 | .NET Framework 4.8 | 30.330 μs | 0.1489 μs | 0.1163 μs |  1.00 | 36.1328 |  0.0305 | 167.59 KB |        1.00 |
|                         |                    |                    |           |           |           |       |         |         |           |             |
| ToPooledListThenToArray |           .NET 6.0 |           .NET 6.0 | 18.862 μs | 0.1393 μs | 0.1235 μs |  1.03 |  8.4534 |  1.0376 |  39.09 KB |        1.00 |
| ToPooledListThenToArray |           .NET 7.0 |           .NET 7.0 | 17.610 μs | 0.1401 μs | 0.1310 μs |  0.96 |  8.4534 |  1.0376 |  39.09 KB |        1.00 |
| ToPooledListThenToArray | .NET Framework 4.8 | .NET Framework 4.8 | 18.351 μs | 0.0828 μs | 0.0774 μs |  1.00 |  8.4534 |  1.0376 |  39.11 KB |        1.00 |
|                         |                    |                    |           |           |           |       |         |         |           |             |
|      UseCountForToArray |           .NET 6.0 |           .NET 6.0 |  6.302 μs | 0.0260 μs | 0.0243 μs |  0.55 |  8.4686 |  1.0529 |  39.09 KB |        1.00 |
|      UseCountForToArray |           .NET 7.0 |           .NET 7.0 |  6.315 μs | 0.0151 μs | 0.0134 μs |  0.55 |  8.4686 |  1.2054 |  39.09 KB |        1.00 |
|      UseCountForToArray | .NET Framework 4.8 | .NET Framework 4.8 | 11.466 μs | 0.0604 μs | 0.0565 μs |  1.00 |  8.4686 |  1.0529 |  39.11 KB |        1.00 |
|                         |                    |                    |           |           |           |       |         |         |           |             |
|       StructLinqToArray |           .NET 6.0 |           .NET 6.0 |  5.048 μs | 0.0278 μs | 0.0246 μs |  0.81 |  8.4686 |  1.0529 |  39.09 KB |        1.00 |
|       StructLinqToArray |           .NET 7.0 |           .NET 7.0 |  8.025 μs | 0.0251 μs | 0.0234 μs |  1.28 |  8.4686 |  1.2054 |  39.09 KB |        1.00 |
|       StructLinqToArray | .NET Framework 4.8 | .NET Framework 4.8 |  6.267 μs | 0.0439 μs | 0.0389 μs |  1.00 |  8.4686 |  1.0529 |  39.11 KB |        1.00 |
