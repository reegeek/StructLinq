using System.Collections;
using System.Collections.Generic;

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

        public GenericEnumerator<T> GetStructEnumerator()
        {
            return new GenericEnumerator<T>(inner.GetEnumerator());
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return GetStructEnumerator();
        }
    }
}
