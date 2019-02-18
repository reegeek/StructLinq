using System.Collections;
using System.Collections.Generic;

namespace StructLinq.IEnumerable
{
    public struct GenericEnumerator<T> : IEnumerator<T>
    {
        #region private fields
        private readonly IEnumerator<T> inner;
        #endregion
        public GenericEnumerator(IEnumerator<T> inner)
        {
            this.inner = inner;
        }
        public bool MoveNext()
        {
            return inner.MoveNext();
        }
        public void Reset()
        {
            inner.Reset();
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            inner.Dispose();
        }
        public T Current => inner.Current;
    }
}