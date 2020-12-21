using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public struct ArrayRefStructEnumerator<T> : IRefCollectionEnumerator<T>
    {
        #region private fields
        private readonly T[] array;
        private readonly int endIndex;
        private readonly int start;
        private int index;
        #endregion
        public ArrayRefStructEnumerator(T[] array, int start, int length)
        {
            this.array = array;
            endIndex = length - 1 + start;
            index =  start - 1;
            this.start = start;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = start-1;
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

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => endIndex + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T Get(int i)
        {
            return ref array[start + i];
        }

    }
}