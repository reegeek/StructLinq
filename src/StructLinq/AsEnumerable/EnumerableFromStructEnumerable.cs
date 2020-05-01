using System.Collections;
using System.Collections.Generic;
using StructLinq.IEnumerable;

namespace StructLinq.AsEnumerable
{
    public class EnumerableFromStructEnumerable<T, TEnumerator> : IEnumerable<T> 
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
            return new StructEnumerator<T,TEnumerator>(structEnumerable.GetEnumerator());
        }
    }
}

