using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IEnumerable;
using StructLinq.SelectMany;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectManyEnumerable<TSource, TSourceEnumerable, TSourceEnumerator, TResult, TResultEnumerable, TResultEnumerator, TFunction> SelectMany<TSource, TSourceEnumerable, TSourceEnumerator, TResult, TResultEnumerable, TResultEnumerator, TFunction>(this TSourceEnumerable enumerable, TFunction function, 
                                                                                                                                                                                                                                                                        Func<TSourceEnumerable, IStructEnumerable<TSource, TSourceEnumerator>> _,
                                                                                                                                                                                                                                                                        Func<TResultEnumerable, IStructEnumerable<TResult, TResultEnumerator>> __)
            where TSourceEnumerable : IStructEnumerable<TSource, TSourceEnumerator>
            where TSourceEnumerator : struct, IStructEnumerator<TSource>
            where TResultEnumerable : IStructEnumerable<TResult, TResultEnumerator>
            where TResultEnumerator : struct, IStructEnumerator<TResult>
            where TFunction : IFunction<TSource, TResultEnumerable>
        {
            return new (enumerable, function);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectManyEnumerable<TSource, TSourceEnumerable, TSourceEnumerator, TResult, StructEnumerableFromIEnumerable<TResult>, GenericEnumerator<TResult>, FuncEnumerable<TSource, TResult>> SelectMany<TSource, TSourceEnumerable, TSourceEnumerator, TResult>(this TSourceEnumerable enumerable, Func<TSource, IEnumerable<TResult>> function)
            where TSourceEnumerable : IStructEnumerable<TSource, TSourceEnumerator>
            where TSourceEnumerator : struct, IStructEnumerator<TSource>
        {
            return new (enumerable, new FuncEnumerable<TSource, TResult>(function));
        }
    }
}
