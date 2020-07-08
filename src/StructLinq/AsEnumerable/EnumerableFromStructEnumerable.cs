using System.Collections;
using System.Collections.Generic;
using StructLinq.IEnumerable;

namespace StructLinq.AsEnumerable
{
    public readonly struct EnumerableFromStructEnumerable<T, TEnumerator> : IEnumerable<T> 
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private readonly IStructEnumerable<T, TEnumerator> structEnumerable;
        public EnumerableFromStructEnumerable(IStructEnumerable<T, TEnumerator> structEnumerable)
        {
            this.structEnumerable = structEnumerable;
        }
        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            var structEnumerator = structEnumerable.GetEnumerator();
            return new StructEnumerator<T,TEnumerator>(ref structEnumerator);
        }
    }
}

