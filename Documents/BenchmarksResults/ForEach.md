## ForEach

### Source
[ForEach.cs](../../src/StructLinq.Benchmark/ForEach.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                      Method |      Mean |    Error |   StdDev | Ratio | Allocated |
|---------------------------- |----------:|---------:|---------:|------:|----------:|
|                  ClrForEach | 382.41 μs | 1.285 μs | 1.202 μs |  1.00 |      40 B |
|                  WithAction | 178.08 μs | 0.383 μs | 0.358 μs |  0.47 |      24 B |
|                  WithStruct |  25.68 μs | 0.043 μs | 0.038 μs |  0.07 |      24 B |
|         ZeroAllocWithStruct | 138.63 μs | 0.474 μs | 0.420 μs |  0.36 |         - |
| ToTypedEnumerableWithStruct | 384.04 μs | 3.147 μs | 2.944 μs |  1.00 |      64 B |
