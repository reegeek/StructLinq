using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public readonly struct ArrayEnumerable<T> : IStructCollection<T, ArrayStructEnumerator<T>>
    {
        #region private fields
        private readonly T[] array;
        private readonly int length;
        #endregion
        public ArrayEnumerable(T[] array, int length)
        {
            this.array = array;
            this.length = length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ArrayStructEnumerator<T> GetEnumerator()
        {
            return new ArrayStructEnumerator<T>(array, length);
        }

        public int Count => length;
    }
}