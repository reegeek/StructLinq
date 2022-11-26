using StructLinq.IEnumerable;
using System.Collections;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public class RefStructEnumerableEnumerable<T, TEnumerator> : IEnumerable<T>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        private readonly RefStructEnum<T, TEnumerator> structEnumerable;

        public RefStructEnumerableEnumerable(RefStructEnum<T, TEnumerator> structEnumerable)
        {
            this.structEnumerable = structEnumerable;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new RefStructEnumerator<T, TEnumerator>(structEnumerable.GetEnumerator());
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
