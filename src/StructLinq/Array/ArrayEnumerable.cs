using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Array
{
    public readonly struct ArrayEnumerable<T> : IStructEnumerable<T, ArrayStructEnumerator<T>> where T : struct
    {
        #region private fields
        private readonly object array;
        private readonly int endIndex;
        #endregion
        public ArrayEnumerable(object array, int endIndex)
        {
            this.array = array;
            this.endIndex = endIndex;
        }

        public ArrayStructEnumerator<T> GetStructEnumerator()
        {
            return new ArrayStructEnumerator<T>(array, endIndex);
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

    public readonly struct RefArrayEnumerable<T> : IStructEnumerable<T, RefArrayStructEnumerator<T>> where T : class
    {
        #region private fields
        private readonly object array;
        private readonly int endIndex;
        #endregion
        public RefArrayEnumerable(object array, int endIndex)
        {
            this.array = array;
            this.endIndex = endIndex;
        }

        public RefArrayStructEnumerator<T> GetStructEnumerator()
        {
            return new RefArrayStructEnumerator<T>(array, endIndex);
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