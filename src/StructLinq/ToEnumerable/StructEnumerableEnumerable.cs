using StructLinq.IEnumerable;
using System.Collections;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public class StructEnumerableEnumerable<T, TEnumerator> : IEnumerable<T>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private readonly StructEnum<T, TEnumerator> structEnumerable;

        public StructEnumerableEnumerable(StructEnum<T, TEnumerator> structEnumerable)
        {
            this.structEnumerable = structEnumerable;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new StructEnumerator<T, TEnumerator>(structEnumerable.GetEnumerator());
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
