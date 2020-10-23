using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Array
{
    public struct ArrayRefEnumerable<T> : IRefStructCollection<T, ArrayRefStructEnumerator<T>>
    {
        #region private fields
        private readonly T[] array;
        private int length;
        private int start;
        #endregion
        public ArrayRefEnumerable(T[] array, int start, int length)
        {
            this.array = array;
            this.length = length;
            this.start = start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ArrayRefStructEnumerator<T> GetEnumerator()
        {
            return new ArrayRefStructEnumerator<T>(array, start, Count);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Max(0, length - start);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int)start + this.start;
                if (length.HasValue)
                    this.length = MathHelpers.Min((int)length.Value + this.start, this.length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return new ArrayRefEnumerable<T>(array, start, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T Get(int i)
        {
            return ref array[i];
        }

    }
}