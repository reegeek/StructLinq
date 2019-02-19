using System;

namespace StructLinq
{
    public static class Functions
    {
        public static IFunctionFactory<TIn, TOut, StructFunctionFromInterface<TIn, TOut>> ToFactory<TIn, TOut>(this IFunction<TIn, TOut> function)
        {
            return new StructFunctionFromInterfaceFactory<TIn, TOut>(function);
        }
        public static IFunctionFactory<TIn, TOut, StructFunctionFromDelegate<TIn, TOut>> ToFactory<TIn, TOut>(this Func<TIn, TOut> function)
        {
            return new StructFunctionFromDelegateFactory<TIn, TOut>(function);
        }
    }

    public struct StructFunctionFromInterface<TIn, TOut> : IFunction<TIn, TOut>
    {
        #region private fields
        private readonly IFunction<TIn, TOut> inner;
        #endregion
        public StructFunctionFromInterface(IFunction<TIn, TOut> inner)
        {
            this.inner = inner;
        }
        public TOut Eval(TIn element)
        {
            return inner.Eval(element);
        }
    }

    public struct StructFunctionFromDelegate<TIn, TOut> : IFunction<TIn, TOut>
    {
        #region private fields
        private readonly Func<TIn, TOut> inner;
        #endregion
        public StructFunctionFromDelegate(Func<TIn, TOut> inner)
        {
            this.inner = inner;
        }
        public TOut Eval(TIn element)
        {
            return inner(element);
        }
    }

    class StructFunctionFromDelegateFactory<TIn, TOut> : IFunctionFactory<TIn, TOut, StructFunctionFromDelegate<TIn, TOut>>
    {
        private readonly Func<TIn, TOut> function;
        public StructFunctionFromDelegateFactory(Func<TIn, TOut> function)
        {
            this.function = function;
        }
        public StructFunctionFromDelegate<TIn, TOut> Build()
        {
            return new StructFunctionFromDelegate<TIn, TOut>(function);
        }
    }

    class StructFunctionFromInterfaceFactory<TIn, TOut> : IFunctionFactory<TIn, TOut,
        StructFunctionFromInterface<TIn, TOut>>
    {
        #region private fields
        private readonly IFunction<TIn, TOut> function;
        #endregion
        public StructFunctionFromInterfaceFactory(IFunction<TIn, TOut> function)
        {
            this.function = function;
        }
        public StructFunctionFromInterface<TIn, TOut> Build()
        {
            return new StructFunctionFromInterface<TIn, TOut>(function);
        }
    }
}