using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public struct ArrayStructEnumerator<T> : IEnumerator<T>
    {
        #region private fields
        private readonly T[] array;
        private readonly int endIndex;
        private int index;
        #endregion
        public ArrayStructEnumerator(ref T[] array)
        {
            this.array = array;
            endIndex = array.Length - 1;
            index = -1;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }
        object IEnumerator.Current => Current;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
        }
        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => array[index];
        }
    }
}
