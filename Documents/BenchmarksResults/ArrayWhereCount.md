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
|                  HandmadedCode |  7.818 μs | 0.0381 μs | 0.0338 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                        SysLinq | 28.221 μs | 0.3126 μs | 0.2771 μs |  3.61 |    0.04 |     - |     - |     - |      48 B |
|         StructLinqWithDelegate | 25.198 μs | 0.1475 μs | 0.1232 μs |  3.22 |    0.02 |     - |     - |     - |      64 B |
| StructLinqWithDelegateZeoAlloc | 27.106 μs | 0.1202 μs | 0.1066 μs |  3.47 |    0.02 |     - |     - |     - |         - |
|         StructLinqWithFunction |  7.768 μs | 0.0525 μs | 0.0491 μs |  0.99 |    0.01 |     - |     - |     - |         - |
