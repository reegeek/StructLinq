using System.Collections;
using System.Collections.Generic;

namespace StructLinq.IEnumerable
{
    public class StructEnumerable<T, TEnumerator> : IEnumerable<T>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private readonly IStructEnumerable<T, TEnumerator> structEnumerable;

        public StructEnumerable(IStructEnumerable<T, TEnumerator> structEnumerable)
        {
            this.structEnumerable = structEnumerable;
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StructEnumerator<T>(structEnumerable.GetEnumerator());
        }
    }
}
