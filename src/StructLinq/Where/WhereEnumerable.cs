using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Where
{
    public readonly struct WhereEnumerable<TIn, TEnumerator, TFunction> : IStructEnumerable<TIn, WhereEnumerator<TIn, TEnumerator, TFunction>>
        where TEnumerator : struct, IEnumerator<TIn> 
        where TFunction : struct, IFunction<TIn, bool>
    {
        private readonly TFunction function;
        private readonly IStructEnumerable<TIn, TEnumerator> inner;
        public WhereEnumerable(in TFunction function, in IStructEnumerable<TIn, TEnumerator> inner)
        {
            this.function = function;
            this.inner = inner;
        }

        public WhereEnumerator<TIn, TEnumerator, TFunction> GetStructEnumerator()
        {
            var enumerator = inner.GetStructEnumerator();
            return new WhereEnumerator<TIn, TEnumerator, TFunction>(function, enumerator);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<TIn> GetEnumerator()
        {
            return GetStructEnumerator();
        }
    }
}
