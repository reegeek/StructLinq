using System;

namespace StructLinq
{
    public struct StructFunction<TIn, TOut> : IFunction<TIn, TOut>
    {
        #region private fields
        private readonly Func<TIn, TOut> inner;
        #endregion
        public StructFunction(Func<TIn, TOut> inner)
        {
            this.inner = inner;
        }
        public readonly TOut Eval(TIn element)
        {
            return inner(element);
        }
    }
}