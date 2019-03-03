using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public class ArrayStructEnumerator<T> : IEnumerator<T>
    {
        #region private fields
        private readonly T[] array;
        private readonly int endIndex;
        private int index = -1;
        private T current;
        #endregion
        public ArrayStructEnumerator(ref T[] array)
        {
            this.array = array;
            endIndex = array.Length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (index >= endIndex)
                return false;
            ++index;
            return index < endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
        }
        public T Current => array[index];
    }
}
