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
        public ArrayRefStructEnumerator(T[] array, int start, int length)
        {
            this.array = array;
            endIndex = length - 1 + start;
            index =  start - 1;
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            
        }

    }
}