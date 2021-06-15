# StructLinq
[![GitHub release](https://img.shields.io/github/v/release/reegeek/StructLinq.svg?logo=GitHub)](https://github.com/reegeek/StructLinq/releases)  
[![Nuget](https://img.shields.io/nuget/v/StructLinq)](https://www.nuget.org/packages/StructLinq/) ![Nuget](https://img.shields.io/nuget/dt/structLinq)  
[![Build Status](https://dev.azure.com/reegeek/StrucLinq/_apis/build/status/reegeek.StructLinq?branchName=master)](https://dev.azure.com/reegeek/StrucLinq/_build/latest?definitionId=2&branchName=master)
[![continuous](https://github.com/reegeek/StructLinq/workflows/continuous/badge.svg)](https://github.com/reegeek/StructLinq/actions?query=workflow%3Acontinuous)  
[![GitHub stars](https://img.shields.io/github/stars/reegeek/StructLinq)](https://github.com/reegeek/StructLinq/stargazers) [![GitHub forks](https://img.shields.io/github/forks/reegeek/StructLinq)](https://github.com/reegeek/StructLinq/network) [![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/reegeek/StructLinq/blob/master/LICENSE)

Implementation in C# of LINQ concept with struct to reduce drastically memory allocation and improve performance. 
Introduce `IRefStructEnumerable` to improve performance when element are fat struct.

---
- [Installation](#Installation)
- [Usage](#Usage)
- [Performances](#Performances)
- [Features](#Features)
  - [BCL bindings](#BCL)
  - [Transformers](#Transformers)
  - [Converters](#Converters)
  - [LINQ Extensions](#LINQ-Extensions)
  - [Other Extensions](#Other-Extensions)
- [IRefStructEnumerable](#IRefStructEnumerable)
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

`x=>x` is used to avoid boxing (and allocation) and to help generic type parameters inference.
You can also improve performance by using struct for Where predicate and select function.

## Performances

All benchmark results are in [here](Documents/BenchmarksResults).
For example following linq sequence:
 ```csharp
    list
      .Where(x => (x & 1) == 0)
      .Select(x => x * 2)
      .Sum();
 ```
 can be replace by:
  ```csharp
    list
      .ToStructEnumerable()
      .Where(x => (x & 1) == 0)
      .Select(x => x * 2)
      .Sum();
 ```
 or if you want zero allocation by:
   ```csharp
    list
      .ToStructEnumerable()
      .Where(x => (x & 1) == 0, x=>x)
      .Select(x => x * 2, x=>x)
      .Sum(x=>x);
 ```
 or if you want zero allocation and better performance by:
  ```csharp
    var where = new WherePredicate();
    var select = new SelectFunction();
    list
      .ToStructEnumerable()
      .Where(ref @where, x => x)
      .Select(ref @select, x => x, x => x)
      .Sum(x => x);
 ```


 [Benchmark](src/StructLinq.Benchmark/ListWhereSelectSum.cs) results are:

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|                            LINQ | 65.116 μs | 0.6153 μs | 0.5756 μs |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 26.146 μs | 0.2402 μs | 0.2247 μs |  0.40 |     - |     - |     - |      96 B |
| StructLinqWithDelegateZeroAlloc | 27.854 μs | 0.0938 μs | 0.0783 μs |  0.43 |     - |     - |     - |         - |
|             StructLinqZeroAlloc |  6.872 μs | 0.0155 μs | 0.0137 μs |  0.11 |     - |     - |     - |         - |
 

`StructLinq` is significatively faster than default `LINQ` implementation.

## Features

Duck typing with `foreach` is available with zero allocation for `IStructEnumerable`.

### BCL

Following class have a `StructLinq` extension method for `IStructEnumerable`:
  - `IEnumerable<T>`
  - `T[]`
  - `List<T>` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))
  - `Dictionary<TKey, TValue>` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))
  - `Hashset<T>` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))
  - `ImmutableArray<T>` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))

### Converters
Following converters are available for :
  - `ToArray`
  - `ToList` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))
  - `ToEnumerable`
### LINQ Extensions
Following extensions are available for :
  - `Aggregate`
  - `All`
  - `Any`
  - `Concat`
  - `Contains`
  - `Count`
  - `Distinct`([zero allocation](Documents/BenchmarksResults/Distinct.md))
  - `ElementAt`
  - `ElementAtOrDefault`
  - `Empty`
  - `Except`([zero allocation](Documents/BenchmarksResults/Except.md))
  - `First`
  - `FirstOrDefault`
  - `Intersect`([zero allocation](Documents/BenchmarksResults/Intersect.md))
  - `Last`
  - `LastOrDefault`
  - `Max`
  - `Min`
  - `OrderBy`([zero allocation](Documents/BenchmarksResults/OrderByArrayOfInt.md))
  - `OrderByDescending`
  - `Range`
  - `Repeat`
  - `Reverse`([zero allocation](Documents/BenchmarksResults/Reverse.md))
  - `Select`
  - `SelectMany`
  - `Skip`
  - `SkipWhile`
  - `Sum`
  - `Take`
  - `TakeWhile`
  - `Union`([zero allocation](Documents/BenchmarksResults/Union.md))	
  - `Where`
### Other Extensions
  - `LongCount`
  - `UIntCount`
  - `Order`
  - `TryFirst`

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

 Duck typing with `foreach` with `ref` is available with zero allocation for `IRefStructEnumerable`.

 ### BCL

Following class have a `StructLinq` extension method for `IRefStructEnumerable`:
  - `T[]`
  - `List<T>` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))

  ### Converters
Following converters are available for :
  - `ToArray`
  - `ToList` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))
  - `ToEnumerable`
### LINQ Extensions
Following extensions are available for :
  - `All`
  - `Any`
  - `Concat`
  - `Contains`
  - `Count`
  - `Distinct`
  - `ElementAt`
  - `ElementAtOrDefault`
  - `Except`
  - `First`
  - `FirstOrDefault`
  - `Intersect`
  - `Last`
  - `Select`
  - `Skip`
  - `SkipWhile`
  - `Sum`
  - `Take`
  - `TakeWhile`
  - `Union`
  - `Where`
### Other Extensions
  - `LongCount`
  - `UIntCount`
  - `TryFirst`




