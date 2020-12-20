using System;
using System.Runtime.CompilerServices;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectCollection<TIn, TOut, TEnumerable, TEnumerator, TFunction> Select<TIn, TOut, TEnumerable, TEnumerator, TFunction>(
            this TEnumerable enumerable, 
            ref TFunction function, 
            Func<TEnumerable, IStructCollection<TIn, TEnumerator>> _, 
            Func<TFunction, IFunction<TIn, TOut>> __)
            where TEnumerator : struct, ICollectionEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : struct, IStructCollection<TIn, TEnumerator>
        {
            return new SelectCollection<TIn, TOut, TEnumerable, TEnumerator, TFunction>(ref function, ref enumerable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectCollection<TIn, TOut, TEnumerable, TEnumerator> Select<TIn, TOut, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TIn, TOut> function, Func<TEnumerable, IStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<TIn>
            where TEnumerable : struct, IStructCollection<TIn, TEnumerator>
        {
            return new SelectCollection<TIn, TOut, TEnumerable, TEnumerator>(function, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectCollection<TIn, TOut, IStructCollection<TIn, TEnumerator>, TEnumerator> Select<TIn, TOut, TEnumerator>(this IStructCollection<TIn, TEnumerator> enumerable, Func<TIn, TOut> function)
            where TEnumerator : struct, ICollectionEnumerator<TIn>
        {
            return new SelectCollection<TIn,TOut,IStructCollection<TIn, TEnumerator>,TEnumerator>(function, ref enumerable);
        }
    }
}