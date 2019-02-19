using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Select
{
    public struct SelectEnumerator<TIn, TOut,TEnumerator, TFunction> : IEnumerator<TOut>
        where TFunction: struct, IFunction<TIn, TOut>
        where TEnumerator: IEnumerator<TIn>
    {
        #region private fields
        private TFunction function;
        private TEnumerator enumerator;
        #endregion
        public SelectEnumerator(ref TFunction function, ref TEnumerator enumerator)
        {
            this.function = function;
            this.enumerator = enumerator;
        }
        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }
        public void Reset()
        {
            enumerator.Reset();
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            enumerator.Dispose();
        }
        public TOut Current => function.Eval(enumerator.Current);
    }
}