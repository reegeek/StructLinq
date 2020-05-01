using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Array;

namespace StructLinq.IEnumerable
{
    public readonly struct StructEnumerableFromIEnumerable<T> : IStructEnumerable<T, GenericEnumerator<T>>
    {
        #region private fields
        private readonly IEnumerable<T> inner;
        #endregion
        public StructEnumerableFromIEnumerable(IEnumerable<T> inner)
        {
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public GenericEnumerator<T> GetEnumerator()
        {
            return new GenericEnumerator<T>(inner.GetEnumerator());
        }
    }
}
