using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public readonly struct ArrayRefEnumerable<T> : IRefStructCollection<T, ArrayRefStructEnumerator<T>>
    {
        #region private fields
        private readonly T[] array;
        private readonly int length;
        #endregion
        public ArrayRefEnumerable(T[] array, int length)
        {
            this.array = array;
            this.length = length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ArrayRefStructEnumerator<T> GetEnumerator()
        {
            return new ArrayRefStructEnumerator<T>(array, length);
        }

        public int Count => length;
    }
}