using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public struct ArrayStructEnumerator<T> : ICollectionEnumerator<T>
    {
        #region private fields
        private readonly T[] array;
        private readonly int endIndex;
        private readonly int start;
        private int index;
        #endregion
        public ArrayStructEnumerator(T[] array, int start, int length)
        {
            this.array = array;
            endIndex = length - 1 + start;
            this.start = start;
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
            index = start - 1;
        }
        public readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => array[index];
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
        public T Get(int i)
        {
            return array[start + i];
        }
    }

    public struct ArrayEnumerable2<T> : IStructEnumerable2<T>
    {
        private readonly T[] array;
        private readonly int endIndex;
        private int index;
        
        public ArrayEnumerable2(T[] array)
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
            index = - 1;
        }
        public readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => array[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Initialization()
        {
            index = -1;
        }
    }

    public static class EnumerableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Enumerator<T, ArrayEnumerable2<T>> GetEnumerator<T>(this ArrayEnumerable2<T> array)
        {
            var clone = array;
            clone.Initialization();
            return new Enumerator<T, ArrayEnumerable2<T>>(clone);
        }
    }
}
