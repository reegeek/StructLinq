using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Where
{
    struct WhereEnumerable<TIn, TEnumerator, TFunction> : ITypedEnumerable<TIn, WhereEnumerator<TIn, TEnumerator, TFunction>>
        where TEnumerator : IEnumerator<TIn> 
        where TFunction : IFunction<TIn, bool>
    {
        private TFunction function;
        private readonly ITypedEnumerable<TIn, TEnumerator> inner;
        public WhereEnumerable(ref TFunction function, ITypedEnumerable<TIn, TEnumerator> inner)
        {
            this.function = function;
            this.inner = inner;
        }
        public WhereEnumerator<TIn, TEnumerator, TFunction> GetTypedEnumerator()
        {
            var enumerator = inner.GetTypedEnumerator();
            return new WhereEnumerator<TIn, TEnumerator, TFunction>(ref function, ref enumerator);
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
