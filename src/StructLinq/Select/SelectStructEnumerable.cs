using System;
using System.Collections.Generic;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static SelectEnumerable<TIn, TOut, TEnumerator, TFunction> Select<TIn, TOut, TEnumerator, TFunction>(this ITypedEnumerable<TIn, TEnumerator> enumerable, ref TFunction function, Id<TOut> _)
            where TEnumerator : struct, IEnumerator<TIn> 
            where TFunction : struct, IFunction<TIn, TOut>
        {
            return enumerable.Select<TIn, TOut, TEnumerator, TFunction>(ref function);
        }
        public static SelectEnumerable<TIn, TOut, TEnumerator, TFunction> Select<TIn, TOut, TEnumerator, TFunction>(this ITypedEnumerable<TIn, TEnumerator> enumerable, ref TFunction function)
            where TEnumerator : struct, IEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
        {
            return new SelectEnumerable<TIn, TOut, TEnumerator, TFunction>(ref function, enumerable);
        }
        public static SelectEnumerable<TIn, TOut, TEnumerator, StructFunction<TIn, TOut>>
            Select<TIn, TOut, TEnumerator>(this ITypedEnumerable<TIn, TEnumerator> enumerable, Func<TIn, TOut> function)
            where TEnumerator : struct, IEnumerator<TIn>
        {
            var fct = function.ToStruct();
            return enumerable.Select(ref fct, Id<TOut>.Value);
        }
    }




}