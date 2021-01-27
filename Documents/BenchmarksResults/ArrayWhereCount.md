## ArrayWhereCount

### Source
[ArrayWhereCount.cs](../../src/StructLinq.Benchmark/ArrayWhereCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  DefaultJob : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT


```
|                         Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                  HandmadedCode |  9.018 μs | 0.1786 μs | 0.3442 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                        SysLinq | 28.411 μs | 0.1726 μs | 0.1614 μs |  3.13 |    0.12 |     - |     - |     - |      48 B |
|         StructLinqWithDelegate | 31.017 μs | 0.6127 μs | 1.5259 μs |  3.47 |    0.24 |     - |     - |     - |      64 B |
| StructLinqWithDelegateZeoAlloc | 30.736 μs | 0.6101 μs | 1.5195 μs |  3.42 |    0.25 |     - |     - |     - |         - |
|         StructLinqWithFunction | 16.965 μs | 0.3245 μs | 0.4104 μs |  1.87 |    0.09 |     - |     - |     - |         - |
