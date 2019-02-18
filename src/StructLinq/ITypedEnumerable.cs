using System.Collections.Generic;

namespace StructLinq
{
    public interface ITypedEnumerable<out T, out TEnumerator> : IEnumerable<T> where TEnumerator : IEnumerator<T>
    {
        TEnumerator GetTypedEnumerator();
    }
}
