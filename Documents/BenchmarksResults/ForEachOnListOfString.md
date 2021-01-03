## ForEachOnListOfString

### Source
[ForEachOnListOfString.cs](../../src/StructLinq.Benchmark/ForEachOnListOfString.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|     Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|    Default | 30.981 μs | 0.1696 μs | 0.1586 μs |  1.00 |     - |     - |     - |         - |
| StructLinq |  7.234 μs | 0.1432 μs | 0.1340 μs |  0.23 |     - |     - |     - |         - |
