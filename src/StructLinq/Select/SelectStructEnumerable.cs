using System;
using System.Collections.Generic;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static ITypedEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
            Select<TIn, TOut, TEnumerator, TFunction>(this ITypedEnumerable<TIn, TEnumerator> enumerable, ref TFunction function, Identity<TOut> output)
            where TEnumerator : IEnumerator<TIn> 
            where TFunction : struct, IFunction<TIn, TOut>
        {
            return new SelectEnumerable<TIn, TOut, TEnumerator, TFunction>(ref function, enumerable);
        }
        public static ITypedEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, StructFunction<TIn, TOut>>>
            Select<TIn, TOut, TEnumerator>(this ITypedEnumerable<TIn, TEnumerator> enumerable, Func<TIn, TOut> function)
            where TEnumerator : IEnumerator<TIn>
        {
            var fct = function.ToStruct();
            return enumerable.Select(ref fct, Identity<TOut>.Instance);
        }
    }




}