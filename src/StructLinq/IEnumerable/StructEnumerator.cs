using System.Collections;
using System.Collections.Generic;

namespace StructLinq.IEnumerable
{
    public class StructEnumerator<T> : IEnumerator<T>
    {
        private readonly IStructEnumerator<T> enumerator;

        public StructEnumerator(IStructEnumerator<T> enumerator)
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
