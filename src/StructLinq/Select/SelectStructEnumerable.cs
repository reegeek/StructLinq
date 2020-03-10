using System;
using System.Runtime.CompilerServices;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> Select<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction function, 
                                                                                                                                              Func<TEnumerable, IStructEnumerable<TIn, TEnumerator>> _, Func<TFunction, IFunction<TIn, TOut>> __)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : struct, IStructEnumerable<TIn, TEnumerator>
        {
            return new SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction>(ref function, ref enumerable);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectEnumerable<TIn, TOut, TEnumerable,  TEnumerator, StructFunction<TIn, TOut>>
            Select<TIn, TOut, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TIn, TOut> function, Func<TEnumerable, IStructEnumerable<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TEnumerable : struct, IStructEnumerable<TIn, TEnumerator>
        {
            var fct = function.ToStruct();
            return new SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, StructFunction<TIn, TOut>>(ref fct, ref enumerable);
        }
    }




}