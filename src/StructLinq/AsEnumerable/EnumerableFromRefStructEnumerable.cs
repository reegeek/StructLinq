using System.Collections;
using System.Collections.Generic;
using StructLinq.IEnumerable;

namespace StructLinq.AsEnumerable
{
    public readonly struct EnumerableFromRefStructEnumerable<T, TEnumerator> : IEnumerable<T> 
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
            var refStructEnumerator = structEnumerable.GetEnumerator();
            return new RefStructEnumerator<T, TEnumerator>(ref refStructEnumerator);
        }
    }
}