# StructLinq
[![GitHub release](https://img.shields.io/github/v/release/reegeek/StructLinq.svg?logo=GitHub)](https://github.com/reegeek/StructLinq/releases)  
[![Nuget](https://img.shields.io/nuget/v/StructLinq)](https://www.nuget.org/packages/StructLinq/) ![Nuget](https://img.shields.io/nuget/dt/structLinq)  
[![Build Status](https://dev.azure.com/reegeek/StrucLinq/_apis/build/status/reegeek.StructLinq?branchName=master)](https://dev.azure.com/reegeek/StrucLinq/_build/latest?definitionId=2&branchName=master)
[![continuous](https://github.com/reegeek/StructLinq/workflows/continuous/badge.svg)](https://github.com/reegeek/StructLinq/actions?query=workflow%3Acontinuous)  
[![GitHub stars](https://img.shields.io/github/stars/reegeek/StructLinq)](https://github.com/reegeek/StructLinq/stargazers) [![GitHub forks](https://img.shields.io/github/forks/reegeek/StructLinq)](https://github.com/reegeek/StructLinq/network) [![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/reegeek/StructLinq/blob/master/LICENSE)

Implementation in C# of LINQ concept with struct to reduce drastically memory allocation and improve performance. 
Introduce `IRefStructEnumerable` to improve performance.

---
- [Installation](#Installation)
- [Usage](#Usage)
- [IRefStructEnumerable](#IRefStructEnumerable)
- [Performances](#Performances)
- [Features](#Features)
  - [BCL bindings](#BCL)
  - [Transformers](#Transformers)
  - [Aggregators](#Aggregators)
  - [Generators](#Generators)
---

## Installation
This library is distributed via [NuGet](https://www.nuget.org/).
To install [`StructLinq`](https://www.nuget.org/packages/StructLinq/) :
  ```
  PM> Install-Package StructLinq
  ```

## Usage

`StructLinq` use massively generic concept and struct "specialization".

```csharp
using StructLinq;
 
int[] array = new [] {1, 2, 3, 4, 5};

int result = array
                .ToStructEnumerable()
                .Where(x => (x & 1) == 0, x=>x)
                .Select(x => x *2, x => x)
                .Sum();
```

`x=>x` is used to avoid boxing and to help generic type parameters inference.
You can also improve performance by using struct for Where predicate and select function.

## IRefStructEnumerable

```csharp
    public interface IRefStructEnumerable<out T, out TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        TEnumerator GetEnumerator();
    }

    public interface IRefStructEnumerator<T>
    {
        bool MoveNext();

        void Reset();

        ref T Current { get; }
    }
```
 `ref Current` allows to avoid copy. I should be very useful when `T` is a fat struct.

## Performances

Benchmark are in [here](src/StructLinq.Benchmark).
For example on following linq sequence:
 ```csharp
    array
      .Where(x => (x & 1) == 0)
      .Select(x => x * 2)
      .Sum();
 ```
 [Benchmark](src/StructLinq.Benchmark/ArrayWhereSelectSum.cs) results are:

 ``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

```
|                                Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                          HandmadeCode |  5.579 us | 0.0414 us | 0.0346 us |  1.00 |    0.00 |     - |     - |     - |         - |
|                               SysLinq | 48.360 us | 0.5377 us | 0.4767 us |  8.67 |    0.06 |     - |     - |     - |     104 B |
| StructRangeWhereSelectSumWithDelegate | 40.848 us | 0.3137 us | 0.2935 us |  7.31 |    0.06 |     - |     - |     - |      40 B |
|             StructRangeWhereSelectSum | 13.703 us | 0.0452 us | 0.0378 us |  2.46 |    0.02 |     - |     - |     - |         - |
 

`StructLinq` is 3.5 time faster than default `LINQ` implementation.

## Features

Duck typing with `foreach` is available with zero allocation for `IStructEnumerable` and also with `Foreach` and `ref` for `IRefStructEnumerable`.

### BCL

Following class have a `StructLinq` extension method:
  - `IEnumerable<T>`
  - `T[]`

### Transformers
Following transformations are available for :
  - `Select`
  - `Where`
### Aggregators
Following aggregators are available:
  - `Count`
  - `LongCount`
  - `UIntCount`
  - `Aggregate`
  - `Sum`
  - `Min`
  - `Max`
### Generators
Following generators are available:
  - `Range`




