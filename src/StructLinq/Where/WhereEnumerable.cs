using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Where
{
    public readonly struct WhereEnumerable<TIn, TEnumerator, TFunction> : ITypedEnumerable<TIn, WhereEnumerator<TIn, TEnumerator, TFunction>>
        where TEnumerator : struct, IEnumerator<TIn> 
        where TFunction : struct, IFunction<TIn, bool>
    {
        private readonly TFunction function;
        private readonly ITypedEnumerable<TIn, TEnumerator> inner;
        public WhereEnumerable(in TFunction function, in ITypedEnumerable<TIn, TEnumerator> inner)
        {
            this.function = function;
            this.inner = inner;
        }

        public WhereEnumerator<TIn, TEnumerator, TFunction> GetTypedEnumerator()
        {
            var enumerator = inner.GetTypedEnumerator();
            return new WhereEnumerator<TIn, TEnumerator, TFunction>(function, enumerator);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<TIn> GetEnumerator()
        {
            return GetTypedEnumerator();
        }
    }
}
