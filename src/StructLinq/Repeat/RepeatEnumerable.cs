using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Repeat
{
    public struct RepeatEnumerable<T> : IStructCollection<T, RepeatEnumerator<T>>
    {
        private readonly T element;
        private uint count;

        public RepeatEnumerable(T element, uint count)
        {
            this.element = element;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly RepeatEnumerator<T> GetEnumerator()
        {
            return new RepeatEnumerator<T>(element, count);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (int) count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                count = start > count ? 0 :
                    length.HasValue ? MathHelpers.Min(length.Value, count - start) : count - start;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return new RepeatEnumerable<T>(element, count);
        }

    }
}
