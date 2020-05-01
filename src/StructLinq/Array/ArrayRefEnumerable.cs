using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public readonly struct ArrayRefEnumerable<T> : IRefStructEnumerable<T, ArrayRefStructEnumerator<T>>
    {
        #region private fields
        private readonly T[] array;
        #endregion
        public ArrayRefEnumerable(T[] array)
        {
            this.array = array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ArrayRefStructEnumerator<T> GetEnumerator()
        {
            return new ArrayRefStructEnumerator<T>(array);
        }
    }
}