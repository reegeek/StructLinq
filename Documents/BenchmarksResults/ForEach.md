## ForEach

### Source
[ForEach.cs](../../src/StructLinq.Benchmark/ForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                      Method |      Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                  ClrForEach | 376.05 μs | 1.870 μs | 1.749 μs |  1.00 |     - |     - |     - |      40 B |
|                  WithAction | 158.81 μs | 0.750 μs | 0.701 μs |  0.42 |     - |     - |     - |      24 B |
|                  WithStruct |  25.32 μs | 0.079 μs | 0.070 μs |  0.07 |     - |     - |     - |      24 B |
|         ZeroAllocWithStruct | 136.73 μs | 0.900 μs | 0.841 μs |  0.36 |     - |     - |     - |         - |
| ToTypedEnumerableWithStruct | 375.81 μs | 1.591 μs | 1.488 μs |  1.00 |     - |     - |     - |      64 B |
