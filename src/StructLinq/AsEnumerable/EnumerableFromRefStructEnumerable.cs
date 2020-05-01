using System.Collections;
using System.Collections.Generic;
using StructLinq.IEnumerable;

namespace StructLinq.AsEnumerable
{
    public class EnumerableFromRefStructEnumerable<T, TEnumerator> : IEnumerable<T> 
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        private readonly IRefStructEnumerable<T, TEnumerator> structEnumerable;
        public EnumerableFromRefStructEnumerable(IRefStructEnumerable<T, TEnumerator> structEnumerable)
        {
            this.structEnumerable = structEnumerable;
        }
        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new RefStructEnumerator<T, TEnumerator>(structEnumerable.GetEnumerator());
        }
    }
}