using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using StructLinq.IEnumerable;

namespace StructLinq.Benchmark
{
    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.101
    //[Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


    //```
    //|                              Method |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
    //|------------------------------------ |----------:|----------:|----------:|----------:|------:|--------:|
    //|            ForEachWithUsingOnStruct |  5.976 us | 0.1193 us | 0.2645 us |  5.880 us |  1.00 |    0.00 |
    //|         ForEachWithoutUsingOnStruct |  2.950 us | 0.0562 us | 0.0711 us |  2.921 us |  0.49 |    0.02 |
    //|       ForEachWithTryFinallyOnStruct |  5.858 us | 0.1554 us | 0.1662 us |  5.796 us |  0.98 |    0.06 |
    //|             ForEachWithUsingOnClass | 31.910 us | 0.6356 us | 0.6527 us | 31.543 us |  5.36 |    0.26 |
    //|          ForEachWithoutUsingOnClass | 15.145 us | 0.1289 us | 0.1077 us | 15.123 us |  2.56 |    0.09 |
    //|        ForEachWithTryFinallyOnClass | 32.244 us | 0.6352 us | 0.9889 us | 32.025 us |  5.38 |    0.35 |


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
            var enumerator = enumerable.GetStructEnumerator();
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
            using (var enumerator = enumerable.GetStructEnumerator())
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
            var enumerator = enumerable.GetStructEnumerator();
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

        public ArrayStructEnumeratorWithDispose<T> GetStructEnumerator()
        {
            return new ArrayStructEnumeratorWithDispose<T>(array);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StructEnumerator<T, ArrayStructEnumeratorWithDispose<T>>(GetStructEnumerator());
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
