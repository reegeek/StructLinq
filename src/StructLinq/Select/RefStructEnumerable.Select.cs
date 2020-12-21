using System;
using System.Runtime.CompilerServices;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> Select<TIn, TOut, TEnumerable, TEnumerator, TFunction>(
            this TEnumerable enumerable, ref TFunction function,
            Func<TEnumerable, IRefStructEnumerable<TIn, TEnumerator>> _, 
            Func<TFunction, IInFunction<TIn, TOut>> __)
            where TEnumerator : struct, IRefCollectionEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : struct, IRefStructEnumerable<TIn, TEnumerator>
        {
            return new RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction>(ref function, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, StructInFunction<TIn, TOut>>
            Select<TIn, TOut, TEnumerable, TEnumerator>(
                this TEnumerable enumerable, 
                InFunc<TIn, TOut> function, 
                Func<TEnumerable, IRefStructEnumerable<TIn, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<TIn>
            where TEnumerable : struct, IRefStructEnumerable<TIn, TEnumerator>
        {
            var fct = function.ToStruct();
            return new RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, StructInFunction<TIn, TOut>>(ref fct, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSelectEnumerable<TIn, TOut, IRefStructEnumerable<TIn, TEnumerator>, TEnumerator, StructInFunction<TIn, TOut>> Select<TIn, TOut, TEnumerator>(
            this IRefStructEnumerable<TIn, TEnumerator> enumerable, 
            InFunc<TIn, TOut> function)
            where TEnumerator : struct, IRefCollectionEnumerator<TIn>
        {
            var fct = function.ToStruct();
            return new RefSelectEnumerable<TIn,TOut,IRefStructEnumerable<TIn, TEnumerator>,TEnumerator,StructInFunction<TIn,TOut>>(ref fct, ref enumerable);
        }
    }
}