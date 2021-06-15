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
        public static SelectManyEnumerable<TSource, TSourceEnumerable, TSourceEnumerator, TResult, TResultEnumerable,
                TResultEnumerator, TFunction>
            SelectMany<TSource, TSourceEnumerable, TSourceEnumerator, TResult, TResultEnumerable, TResultEnumerator,
                TFunction>(
                this TSourceEnumerable enumerable,
                TFunction function,
                Func<TSourceEnumerable, IStructEnumerable<TSource, TSourceEnumerator>> _,
                Func<TResultEnumerable, IStructEnumerable<TResult, TResultEnumerator>> __,
                Func<TFunction, IFunction<TSource, TResultEnumerable>> ___)
            where TSourceEnumerable : IStructEnumerable<TSource, TSourceEnumerator>
            where TSourceEnumerator : struct, IStructEnumerator<TSource>
            where TResultEnumerable : IStructEnumerable<TResult, TResultEnumerator>
            where TResultEnumerator : struct, IStructEnumerator<TResult>
            where TFunction : IFunction<TSource, TResultEnumerable>
        {
            return new(enumerable, function);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectManyEnumerable<TSource, IStructEnumerable<TSource, TSourceEnumerator>, TSourceEnumerator,
                TResult, StructEnumerableFromIEnumerable<TResult>, GenericEnumerator<TResult>,
                FuncEnumerable<TSource, TResult>>
            SelectMany<TSource, TSourceEnumerator, TResult>(
                this IStructEnumerable<TSource, TSourceEnumerator> enumerable,
                Func<TSource, IEnumerable<TResult>> function)
            where TSourceEnumerator : struct, IStructEnumerator<TSource>
        {
            return new(enumerable, new FuncEnumerable<TSource, TResult>(function));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectManyEnumerable<TSource, IStructEnumerable<TSource, TSourceEnumerator>, TSourceEnumerator,
                TResult, TResultEnumerable, TResultEnumerator,
                FuncEnumerable<TSource, TResult, TResultEnumerable, TResultEnumerator>>
            SelectMany<TSource, TSourceEnumerator, TResult, TResultEnumerable, TResultEnumerator>(
                this IStructEnumerable<TSource, TSourceEnumerator> enumerable,
                Func<TSource, TResultEnumerable> function,
                Func<TResultEnumerable, IStructEnumerable<TResult, TResultEnumerator>> _,
                Func<TResultEnumerator, IStructEnumerator<TResult>> __)
            
            where TSourceEnumerator : struct, IStructEnumerator<TSource>
            where TResultEnumerable : IStructEnumerable<TResult, TResultEnumerator>
            where TResultEnumerator : struct, IStructEnumerator<TResult>
        {
            return new(enumerable, new FuncEnumerable<TSource, TResult, TResultEnumerable, TResultEnumerator>(function));
        }

    }
}
