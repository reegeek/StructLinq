using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Array
{
    struct ArrayEnumerable<T> : ITypedEnumerable<T, ArrayStructEnumerator<T>>
    {
        #region private fields
        private T[] array;
        #endregion
        public ArrayEnumerable(ref T[] array)
        {
            this.array = array;
        }
        public ArrayStructEnumerator<T> GetTypedEnumerator()
        {
            return new ArrayStructEnumerator<T>(ref array);
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