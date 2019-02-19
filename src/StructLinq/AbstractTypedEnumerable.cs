using System.Collections;
using System.Collections.Generic;

namespace StructLinq
{
    abstract class AbstractTypedEnumerable<T, TEnumerator> : ITypedEnumerable<T, TEnumerator>
        where TEnumerator : IEnumerator<T>
    {
        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return GetTypedEnumerator();
        }
        public abstract TEnumerator GetTypedEnumerator();
    }
}