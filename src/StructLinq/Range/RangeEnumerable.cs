using System.Runtime.CompilerServices;

namespace StructLinq.Range
{
    public readonly struct RangeEnumerable : IStructCollection<int, RangeEnumerator>
    {
        #region private fields
        private readonly int start;
        private readonly int count;
        #endregion
        public RangeEnumerable(int start, int count)
        {
            this.start = start;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RangeEnumerator GetEnumerator()
        {
            return new RangeEnumerator(start, count);
        }

        public int Count => count;
    }
}
