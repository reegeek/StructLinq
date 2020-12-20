using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Range
{
    public struct RangeEnumerable : IStructCollection<int, RangeEnumerator>
    {
        #region private fields
        private int start;
        private int count;
        #endregion
        public RangeEnumerable(int start, int count)
        {
            this.start = start;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly RangeEnumerator GetEnumerator()
        {
            return new RangeEnumerator(start, Count);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Max(0,  count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int) start + this.start;
                if (length.HasValue)
                    count = MathHelpers.Min((int) length, count - (int) start);
                else
                    count -= (int) start;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Get(int i)
        {
            return start + i;
        }
    }
}
