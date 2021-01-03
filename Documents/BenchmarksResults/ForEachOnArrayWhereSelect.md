## ForEachOnArrayWhereSelect

### Source
[ForEachOnArrayWhereSelect.cs](../../src/StructLinq.Benchmark/ForEachOnArrayWhereSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                             Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
|                            SysLinq | 43.88 μs | 0.185 μs | 0.173 μs |     - |     - |     - |     104 B |
|             StructLinqWithDelegate | 35.04 μs | 0.137 μs | 0.128 μs |     - |     - |     - |         - |
| StructLinqWithDelegateAsEnumerable | 56.75 μs | 0.338 μs | 0.317 μs |     - |     - |     - |     104 B |
|                         StructLinq | 15.00 μs | 0.019 μs | 0.016 μs |     - |     - |     - |         - |
|             StructLinqAsEnumerable | 39.09 μs | 0.232 μs | 0.217 μs |     - |     - |     - |     104 B |
