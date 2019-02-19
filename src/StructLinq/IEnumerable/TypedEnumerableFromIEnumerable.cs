using System.Collections.Generic;

namespace StructLinq.IEnumerable
{
    class TypedEnumerableFromIEnumerable<T> : AbstractTypedEnumerable<T, GenericEnumerator<T>>
    {
        #region private fields
        private readonly IEnumerable<T> inner;
        #endregion
        public TypedEnumerableFromIEnumerable(IEnumerable<T> inner)
        {
            this.inner = inner;
        }
        public override GenericEnumerator<T> GetTypedEnumerator()
        {
            return new GenericEnumerator<T>(inner.GetEnumerator());
        }
    }
}
