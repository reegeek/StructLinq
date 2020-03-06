namespace StructLinq.Where
{
    public readonly struct WhereEnumerable<TIn, TEnumerator, TFunction> : IStructEnumerable<TIn, WhereEnumerator<TIn, TEnumerator, TFunction>>
        where TEnumerator : struct, IStructEnumerator<TIn> 
        where TFunction : struct, IFunction<TIn, bool>
    {
        private readonly TFunction function;
        private readonly IStructEnumerable<TIn, TEnumerator> inner;
        public WhereEnumerable(in TFunction function, in IStructEnumerable<TIn, TEnumerator> inner)
        {
            this.function = function;
            this.inner = inner;
        }

        public WhereEnumerator<TIn, TEnumerator, TFunction> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new WhereEnumerator<TIn, TEnumerator, TFunction>(function, enumerator);
        }

    }
}
