using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StructLinq.Range
{
    class RangeEnumerable : ITypedEnumerable<int, RangeEnumerator>
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
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<int> GetEnumerator()
        {
            return GetTypedEnumerator();
        }
        public RangeEnumerator GetTypedEnumerator()
        {
            return new RangeEnumerator(start, count);
        }
    }
}
