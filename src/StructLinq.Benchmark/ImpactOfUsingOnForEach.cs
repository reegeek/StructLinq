using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.IEnumerable;

namespace StructLinq.Benchmark
{
    
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [DisassemblyDiagnoser(4)]
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
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            foreach (var input in this)
            {
                if (!visitor.Visit(input))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
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
