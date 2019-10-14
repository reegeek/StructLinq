using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Select
{
    public readonly struct SelectEnumerable<TIn, TOut, TEnumerator, TFunction> : IStructEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : struct, IEnumerator<TIn>
    {
        #region private fields
        private readonly TFunction function;
        private readonly IStructEnumerable<TIn, TEnumerator> inner;
        #endregion
        public SelectEnumerable(in TFunction function, in IStructEnumerable<TIn, TEnumerator> inner)
        {
            this.function = function;
            this.inner = inner;
        }

        public SelectEnumerator<TIn, TOut, TEnumerator, TFunction> GetStructEnumerator()
        {
            var typedEnumerator = inner.GetStructEnumerator();
            return new SelectEnumerator<TIn, TOut, TEnumerator, TFunction>(function, typedEnumerator);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<TOut> GetEnumerator()
        {
            return GetStructEnumerator();
        }
    }
}

    
