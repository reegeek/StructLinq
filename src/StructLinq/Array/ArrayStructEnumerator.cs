using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public struct ArrayStructEnumerator<T> : IStructEnumerator<T>
    {
        #region private fields
        private readonly T[] array;
        private readonly int endIndex;
        private int index;
        #endregion
        public ArrayStructEnumerator(T[] array, int length)
        {
            this.array = array;
            endIndex = length - 1;
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
        public readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => array[index];
        }
    }
}
