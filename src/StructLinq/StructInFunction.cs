namespace StructLinq
{
    public struct StructInFunction<TIn, TOut> : IInFunction<TIn, TOut>
    {
        #region private fields
        private readonly InFunc<TIn, TOut> inner;
        #endregion
        public StructInFunction(InFunc<TIn, TOut> inner)
        {
            this.inner = inner;
        }
        public readonly TOut Eval(in TIn element)
        {
            return inner(in element);
        }
    }
}