using System.Collections;
using System.Collections.Generic;

namespace StructLinq.IEnumerable
{
    public struct RefStructEnumerator<T, TStructEnumerator> : IEnumerator<T> where
        TStructEnumerator : IRefStructEnumerator<T>
    {
        private TStructEnumerator enumerator;

        public RefStructEnumerator(TStructEnumerator enumerator)
        {
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
        }

        public T Current => enumerator.Current;
    }
}