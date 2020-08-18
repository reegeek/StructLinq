using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Array
{
    public struct ArrayEnumerable<T> : IStructCollection<T, ArrayStructEnumerator<T>>
    {
        #region private fields
        private readonly T[] array;
        private int length;
        private int start;
        #endregion
        public ArrayEnumerable(T[] array, int start, int length)
        {
            this.array = array;
            this.length = length;
            this.start = start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ArrayStructEnumerator<T> GetEnumerator()
        {
            return new ArrayStructEnumerator<T>(array, start, length);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint length)
        {
            this.start = (int)start + this.start;
            this.length = MathHelpers.Min((int)length + this.start, this.length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return new ArrayEnumerable<T>(array, start, length);
        }
    }
}