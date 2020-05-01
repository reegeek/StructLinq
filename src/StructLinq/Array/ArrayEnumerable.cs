using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ArrayStructEnumerator<T> GetEnumerator()
        {
            return new ArrayStructEnumerator<T>(array);
        }
    }
}