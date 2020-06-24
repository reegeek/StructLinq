using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.IEnumerable;

namespace StructLinq.Benchmark
{
    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.301
    //[Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
    //Job-BNPWEC : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT
    //Job-AOFHFD : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


    //```
    //|                        Method |       Runtime |      Mean |     Error |    StdDev | Ratio |
    //|------------------------------ |-------------- |----------:|----------:|----------:|------:|
    //|      ForEachWithUsingOnStruct |      .NET 4.8 |  2.812 us | 0.0017 us | 0.0016 us |  1.00 |
    //|   ForEachWithoutUsingOnStruct |      .NET 4.8 |  2.813 us | 0.0069 us | 0.0064 us |  1.00 |
    //| ForEachWithTryFinallyOnStruct |      .NET 4.8 |  2.811 us | 0.0023 us | 0.0021 us |  1.00 |
    //|       ForEachWithUsingOnClass |      .NET 4.8 | 30.821 us | 0.0089 us | 0.0074 us | 10.96 |
    //|    ForEachWithoutUsingOnClass |      .NET 4.8 | 14.895 us | 0.0135 us | 0.0127 us |  5.30 |
    //|  ForEachWithTryFinallyOnClass |      .NET 4.8 | 30.815 us | 0.0127 us | 0.0099 us | 10.96 |
    //|                               |               |           |           |           |       |
    //|      ForEachWithUsingOnStruct | .NET Core 3.1 |  2.813 us | 0.0019 us | 0.0018 us |  1.00 |
    //|   ForEachWithoutUsingOnStruct | .NET Core 3.1 |  2.811 us | 0.0014 us | 0.0013 us |  1.00 |
    //| ForEachWithTryFinallyOnStruct | .NET Core 3.1 |  2.811 us | 0.0025 us | 0.0022 us |  1.00 |
    //|       ForEachWithUsingOnClass | .NET Core 3.1 | 28.011 us | 0.0236 us | 0.0209 us |  9.96 |
    //|    ForEachWithoutUsingOnClass | .NET Core 3.1 | 14.949 us | 0.0196 us | 0.0183 us |  5.31 |
    //|  ForEachWithTryFinallyOnClass | .NET Core 3.1 | 28.007 us | 0.0098 us | 0.0092 us |  9.96 |



    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [DisassemblyDiagnoser(recursiveDepth: 4)]
    public class ImpactOfUsingOnForEach
    {
        private const int Count = 10000;

        private ArrayEnumerableWithDispose<Class> arrayOfClass;
        private ArrayEnumerableWithDispose<Struct> arrayOfStruct;

        public ImpactOfUsingOnForEach()
        {
            arrayOfClass = new ArrayEnumerableWithDispose<Class>(Enumerable.Range(0, Count).Select(x => new Class(x)).ToArray());
            arrayOfStruct = new ArrayEnumerableWithDispose<Struct>(Enumerable.Range(0, Count).Select(x => new Struct(x)).ToArray());
        }

        [Benchmark(Baseline = true)]
        public void ForEachWithUsingOnStruct()
        {
            ForEachWithUsing(ref arrayOfStruct, x => x);
        }

        [Benchmark]
        public void ForEachWithoutUsingOnStruct()
        {
            ForEachWithoutUsing(ref arrayOfStruct, x => x);
        }

        [Benchmark]
        public void ForEachWithTryFinallyOnStruct()
        {
            ForEachWithTryFinally(ref arrayOfStruct, x => x);
        }

        [Benchmark]
        public void ForEachWithUsingOnClass()
        {
            ForEachWithUsing(ref arrayOfClass, x => x);
        }


        [Benchmark]
        public void ForEachWithoutUsingOnClass()
        {
            ForEachWithoutUsing(ref arrayOfClass, x => x);
        }

        [Benchmark]
        public void ForEachWithTryFinallyOnClass()
        {
            ForEachWithTryFinally(ref arrayOfClass, x => x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEachWithoutUsing<T, TEnumerator, TEnumerable>(ref TEnumerable enumerable,
                                                                            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>, IDisposable
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
            }

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEachWithUsing<T, TEnumerator, TEnumerable>(ref TEnumerable enumerable,
                                                                         Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>, IDisposable
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            using (var enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEachWithTryFinally<T, TEnumerator, TEnumerable>(ref TEnumerable enumerable,
                                                                              Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>, IDisposable
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }


        private sealed class Class
        {
            public readonly int Integer;
            public Class(int integer)
            {
                Integer = integer;
            }
        }

        private readonly struct Struct
        {
            public readonly int Integer;
            public Struct(int integer)
            {
                Integer = integer;
            }
        }
    }

    public readonly struct ArrayEnumerableWithDispose<T> : IStructEnumerable<T, ArrayStructEnumeratorWithDispose<T>>
    {
        #region private fields
        private readonly T[] array;
        #endregion
        public ArrayEnumerableWithDispose(T[] array)
        {
            this.array = array;
        }

        public ArrayStructEnumeratorWithDispose<T> GetEnumerator()
        {
            return new ArrayStructEnumeratorWithDispose<T>(array);
        }

        public IEnumerator<T> GetIEnumerator()
        {
            return new StructEnumerator<T, ArrayStructEnumeratorWithDispose<T>>(GetEnumerator());
        }
    }

    public struct ArrayStructEnumeratorWithDispose<T> : IStructEnumerator<T>, IDisposable
    {
        #region private fields
        private readonly T[] array;
        private readonly int endIndex;
        private int index;
        #endregion
        public ArrayStructEnumeratorWithDispose(T[] array)
        {
            this.array = array;
            endIndex = array.Length - 1;
            index = -1;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }
        public readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => array[index];
        }

        public void Dispose()
        {
        }
    }
}
