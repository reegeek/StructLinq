using System;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public static class Functions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructFunction<TIn, TOut> ToStruct<TIn, TOut>(this Func<TIn, TOut> function)
        {
            return new(function);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructInFunction<TIn, TOut> ToStruct<TIn, TOut>(this InFunc<TIn, TOut> function)
        {
            return new(function);
        }
    }

    public delegate TOut InFunc<TIn, out TOut>(in TIn element);
}