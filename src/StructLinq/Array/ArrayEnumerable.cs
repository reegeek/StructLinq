using System.Collections;
using System.Collections.Generic;
using StructLinq.IEnumerable;

namespace StructLinq.Array
{
    public readonly struct ArrayEnumerable<T> : IStructEnumerable<T, ArrayStructEnumerator<T>>
    {
        #region private fields
        private readonly T[] array;
        #endregion
        public ArrayEnumerable(T[] array)
        {
            this.array = array;
        }

        public ArrayStructEnumerator<T> GetStructEnumerator()
        {
            return new ArrayStructEnumerator<T>(array);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StructEnumerator<T>(GetStructEnumerator());
        }
    }
}