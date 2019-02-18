using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StructLinq.IEnumerable
{
    class TypedEnumerableFromIEnumerable<T> : ITypedEnumerable<T, GenericEnumerator<T>>
    {
        #region private fields
        private readonly IEnumerable<T> inner;
        #endregion
        public TypedEnumerableFromIEnumerable(IEnumerable<T> inner)
        {
            this.inner = inner;
        }
        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return GetTypedEnumerator();
        }
        public GenericEnumerator<T> GetTypedEnumerator()
        {
            return new GenericEnumerator<T>(inner.GetEnumerator());
        }
    }
}
