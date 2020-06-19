using System.Collections;
using System.Collections.Generic;

namespace StructLinq.IEnumerable
{
    public struct StructEnumerator<T, TStructEnumerator> : IEnumerator<T> where 
        TStructEnumerator : IStructEnumerator<T>
    {
        private TStructEnumerator enumerator;

        public StructEnumerator(TStructEnumerator enumerator)
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
            enumerator.Dispose();
        }

        public T Current => enumerator.Current;
    }
}
