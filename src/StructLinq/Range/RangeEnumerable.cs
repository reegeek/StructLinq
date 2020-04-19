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
        public RangeEnumerator GetStructEnumerator()
        {
            return new RangeEnumerator(start, count);
        }

        /// <summary>
        ///An enumerator, duck-typing-compatible with foreach.
        /// </summary>
        public RangeEnumerator GetEnumerator()
        {
            return GetStructEnumerator();
        }
        
        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new StructEnumerator<int, RangeEnumerator>(GetStructEnumerator());
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new StructEnumerator<int, RangeEnumerator>(GetStructEnumerator());
        }

    }
}
