using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public struct ArrayRefStructEnumerator<T> : IRefStructEnumerator<T>
    {
        #region private fields
        private readonly T[] array;
        private readonly int endIndex;
        private int index;
        #endregion
        public ArrayRefStructEnumerator(T[] array)
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
        public ref T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref  array[index];
        }
    }
}