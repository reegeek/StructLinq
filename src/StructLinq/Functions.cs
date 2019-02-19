using System;

namespace StructLinq
{
    public static class Functions
    {
        public static IFunctionFactory<TIn, TOut, StructFunction<TIn, TOut>> ToFactory<TIn, TOut>(this Func<TIn, TOut> function)
        {
            return new StructFunctionFactory<TIn, TOut>(function);
        }
        public static StructFunction<TIn, TOut> ToStruct<TIn, TOut>(this Func<TIn, TOut> function)
        {
            return new StructFunction<TIn, TOut>(function);
        }
    }

    public struct StructFunction<TIn, TOut> : IFunction<TIn, TOut>
    {
        #region private fields
        private readonly Func<TIn, TOut> inner;
        #endregion
        public StructFunction(Func<TIn, TOut> inner)
        {
            this.inner = inner;
        }
        public TOut Eval(TIn element)
        {
            return inner(element);
        }
    }

    class StructFunctionFactory<TIn, TOut> : IFunctionFactory<TIn, TOut, StructFunction<TIn, TOut>>
    {
        private readonly Func<TIn, TOut> function;
        public StructFunctionFactory(Func<TIn, TOut> function)
        {
            this.function = function;
        }
        public StructFunction<TIn, TOut> Build()
        {
            return new StructFunction<TIn, TOut>(function);
        }
    }
}