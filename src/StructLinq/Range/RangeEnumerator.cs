using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Range
{
    public struct RangeEnumerator : IEnumerator<int>
    {
        #region private fields
        private int index;
        private readonly int end;
        private readonly int start;
        #endregion
        public RangeEnumerator(int start, int count)
        {
            end = start + count - 1;
            this.start = start;
            index = start - 1;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= end;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = start - 1;
        }
        readonly object IEnumerator.Current => Current;
        public readonly void Dispose()
        {
        }
        public readonly int Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => index;
        }
    }
}