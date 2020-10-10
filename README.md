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
To install BCL wrapper use [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/) :
  ```
  PM> Install-Package StructLinq.BCL
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

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                          Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                            LINQ | 78.19 us | 1.615 us | 1.432 us |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 45.97 us | 0.469 us | 0.439 us |  0.59 |     - |     - |     - |     104 B |
| StructLinqWithDelegateZeroAlloc | 44.63 us | 0.411 us | 0.385 us |  0.57 |     - |     - |     - |         - |
|             StructLinqZeroAlloc | 15.22 us | 0.031 us | 0.028 us |  0.19 |     - |     - |     - |         - |
 

`StructLinq` is significatively faster than default `LINQ` implementation.

## Features

Duck typing with `foreach` is available with zero allocation for `IStructEnumerable` and also with `Foreach` and `ref` for `IRefStructEnumerable`.

### BCL

Following class have a `StructLinq` extension method for `IStructEnumerable`:
  - `IEnumerable<T>`
  - `T[]`
  - `List<T>` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))
  - `Dictionary<TKey, TValue>` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))

Following class have a `StructLinq` extension method for `IRefStructEnumerable`:
  - `T[]`
  - `List<T>` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))
  

### Converters
Following converters are available for :
  - `ToArray`
  - `ToList` (in [`Struct.Linq.BCL`](https://www.nuget.org/packages/StructLinq.BCL/))
### Extensions
Following extensions are available for :
  - `Range`
  - `Repeat`
  - `Empty`
  - `Select`
  - `Where`
  - `Take`
  - `Skip`
  - `Distinct`([zero allocation](Documents/BenchmarksResults/Distinct.md))
  - `Reverse`([zero allocation](Documents/BenchmarksResults/Reverse.md))
  - `OrderBy`([zero allocation](Documents/BenchmarksResults/OrderByArrayOfInt.md))
  - `Concat`
  - `Count`
  - `LongCount`
  - `UIntCount`
  - `Aggregate`
  - `Sum`
  - `Min`
  - `Max`
  - `Contains`
  - `All`
  - `Any`
  - `Except`([zero allocation](Documents/BenchmarksResults/Except.md))
  - `Union`([zero allocation](Documents/BenchmarksResults/Union.md))	





