using System;

namespace StructLinq
{
    public static class Functions
    {
        public static StructFunction<TIn, TOut> ToStruct<TIn, TOut>(this Func<TIn, TOut> function)
        {
            return new StructFunction<TIn, TOut>(function);
        }
        public static StructInFunction<TIn, TOut> ToStruct<TIn, TOut>(this InFunc<TIn, TOut> function)
        {
            return new StructInFunction<TIn, TOut>(function);
        }
    }

    public delegate TOut InFunc<TIn, out TOut>(in TIn element);
}