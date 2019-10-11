using System.Collections;
using System.Collections.Generic;

namespace StructLinq.Range
{
    public readonly struct RangeEnumerable : ITypedEnumerable<int, RangeEnumerator>
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

        public RangeEnumerator GetTypedEnumerator()
        {
            return new RangeEnumerator(start, count);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<int> GetEnumerator()
        {
            return GetTypedEnumerator();
        }
    }
}
