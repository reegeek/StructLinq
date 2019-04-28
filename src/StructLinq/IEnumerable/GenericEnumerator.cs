using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.IEnumerable
{
    public readonly struct GenericEnumerator<T> : IEnumerator<T>
    {
        #region private fields
        private readonly IEnumerator<T> inner;
        #endregion
        public GenericEnumerator(IEnumerator<T> inner)
        {
            this.inner = inner;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return inner.MoveNext();
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            inner.Reset();
        }
        object IEnumerator.Current => Current;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            inner.Dispose();
        }
        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => inner.Current;
        }
    }
}