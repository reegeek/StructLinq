using System;
using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Range
{
    public struct RangeEnumerator : IEnumerator<int>
    {
        #region private fields
        private readonly int start;
        private readonly int end;
        #endregion
        public RangeEnumerator(int start, int count)
        {
            this.start = start;
            end = start + count;
            //not perfect if start = Int.MinValue
            Current = start - 1;
        }
        public bool MoveNext()
        {
            return ++Current != end;
        }
        public void Reset()
        {
            Current = start-1;
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
        }
        public int Current { get; private set; }
    }
}