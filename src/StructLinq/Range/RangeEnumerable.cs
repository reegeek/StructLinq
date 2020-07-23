using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IEnumerable;

namespace StructLinq.Range
{
    public readonly struct RangeEnumerable : IStructEnumerable<int, RangeEnumerator>
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

        internal int Count => count;
    }
}
