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

        /// <summary>
        ///An enumerator, duck-typing-compatible with foreach.
        /// </summary>
        public ArrayStructEnumerator<T> GetEnumerator()
        {
            return GetStructEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new StructEnumerator<T, ArrayStructEnumerator<T>>(GetStructEnumerator());
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new StructEnumerator<T, ArrayStructEnumerator<T>>(GetStructEnumerator());
        }
    }
}