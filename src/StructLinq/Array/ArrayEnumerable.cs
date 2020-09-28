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
        private int count;
        #endregion

        public ArrayEnumerable(T[] array, int start, int length)
        {
            this.array = array;
            this.length = length;
            this.start = start;
            count = length - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ArrayStructEnumerator<T> GetEnumerator()
        {
            return new ArrayStructEnumerator<T>(array, start, count);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int)start + this.start;
                if (length.HasValue)
                {
                    this.length = MathHelpers.Min((int)length.Value + this.start, this.length);
                    count = MathHelpers.Max(0, this.length - this.start);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return new ArrayEnumerable<T>(array, start, length);
        }
    }
}