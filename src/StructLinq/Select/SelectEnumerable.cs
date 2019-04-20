using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Select
{
    struct SelectEnumerable<TIn, TOut, TEnumerator, TFunction> : ITypedEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : IEnumerator<TIn>
    {
        #region private fields
        private TFunction function;
        private readonly ITypedEnumerable<TIn, TEnumerator> inner;
        #endregion
        public SelectEnumerable(ref TFunction function, ITypedEnumerable<TIn, TEnumerator> inner)
        {
            this.function = function;
            this.inner = inner;
        }
        public SelectEnumerator<TIn, TOut, TEnumerator, TFunction> GetTypedEnumerator()
        {
            var typedEnumerator = inner.GetTypedEnumerator();
            return new SelectEnumerator<TIn, TOut, TEnumerator, TFunction>(ref function, ref typedEnumerator);
        }
        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<TOut> GetEnumerator()
        {
            return GetTypedEnumerator();
        }
    }
}

    
