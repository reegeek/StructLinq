## HashSet

### Source
[HashSet.cs](../../src/StructLinq.Benchmark/HashSet.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|     Method |           Job |       Runtime | ItemCount |         Mean |      Error |      StdDev |       Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------------- |-------------- |---------- |-------------:|-----------:|------------:|-------------:|------:|--------:|------:|------:|------:|----------:|
|       LINQ |      .NET 4.8 |      .NET 4.8 |         2 |    16.348 ns |  0.3521 ns |   0.3121 ns |    16.272 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |         2 |     4.786 ns |  0.0217 ns |   0.0192 ns |     4.782 ns |  0.29 |    0.01 |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |         2 |     7.569 ns |  0.0403 ns |   0.0377 ns |     7.564 ns |  0.46 |    0.01 |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |         2 |     4.822 ns |  0.0098 ns |   0.0087 ns |     4.823 ns |  0.30 |    0.01 |     - |     - |     - |         - |
|            |               |               |           |              |            |             |              |       |         |       |       |       |           |
|       LINQ |      .NET 4.8 |      .NET 4.8 |       100 |   302.095 ns |  1.8084 ns |   1.6031 ns |   301.756 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |       100 |   123.085 ns |  0.4747 ns |   0.4208 ns |   123.094 ns |  0.41 |    0.00 |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |       100 |   241.301 ns |  0.8109 ns |   0.7189 ns |   241.210 ns |  0.80 |    0.01 |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |       100 |   156.282 ns |  0.8925 ns |   0.8348 ns |   156.020 ns |  0.52 |    0.00 |     - |     - |     - |         - |
|            |               |               |           |              |            |             |              |       |         |       |       |       |           |
|       LINQ |      .NET 4.8 |      .NET 4.8 |      1000 | 2,949.675 ns | 32.9274 ns |  29.1893 ns | 2,940.911 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |      1000 | 1,197.428 ns | 23.7338 ns |  22.2006 ns | 1,191.498 ns |  0.41 |    0.01 |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |      1000 | 2,475.769 ns | 49.0637 ns | 100.2240 ns | 2,436.105 ns |  0.89 |    0.02 |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |      1000 | 1,547.644 ns | 30.6865 ns |  30.1383 ns | 1,535.355 ns |  0.53 |    0.01 |     - |     - |     - |         - |
