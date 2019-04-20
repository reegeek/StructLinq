using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Range
{
    public struct RangeEnumerator : IEnumerator<int>
    {
        #region private fields
        private readonly int start;
        private readonly int count;
        private int index;
        #endregion
        public RangeEnumerator(int start, int count)
        {
            this.start = start;
            this.count = count;
            index = 0;
            Current = default(int);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (index >= count)
                return false;
            Current = start + index;
            index++;
            return true;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = 0;
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
        }
        public int Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
            private set;
        }
    }
}