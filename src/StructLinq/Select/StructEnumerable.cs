using System;
using System.Collections.Generic;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static ITypedEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
            Select<TIn, TOut, TEnumerator, TFunction>(this ITypedEnumerable<TIn, TEnumerator> enumerable, ref TFunction function)
            where TEnumerator : IEnumerator<TIn> 
            where TFunction : struct, IFunction<TIn, TOut>
        {
            return new SelectEnumerable<TIn, TOut, TEnumerator, TFunction>(ref function, enumerable);
        }
        public static ITypedEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
            Select<TIn, TOut, TEnumerator, TFunction>(this ITypedEnumerable<TIn, TEnumerator> enumerable, IFunctionFactory<TIn, TOut, TFunction> factory)
            where TEnumerator : IEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
        {
            var function = factory.Build();
            return new SelectEnumerable<TIn, TOut, TEnumerator, TFunction>(ref function, enumerable);
        }
        public static ITypedEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, StructFunction<TIn, TOut>>>
            Select<TIn, TOut, TEnumerator>(this ITypedEnumerable<TIn, TEnumerator> enumerable, Func<TIn, TOut> function)
            where TEnumerator : IEnumerator<TIn>
        {
            return enumerable.Select(function.ToFactory());
        }
    }




}