using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Array
{
    public readonly struct ArrayEnumerable<T> : ITypedEnumerable<T, ArrayStructEnumerator<T>>
    {
        #region private fields
        private readonly T[] array;
        #endregion
        public ArrayEnumerable(T[] array)
        {
            this.array = array;
        }

        public ArrayStructEnumerator<T> GetTypedEnumerator()
        {
            return new ArrayStructEnumerator<T>(array);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return GetTypedEnumerator();
        }
    }
}