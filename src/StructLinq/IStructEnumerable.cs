using System.Collections.Generic;

namespace StructLinq
{
    public interface IStructEnumerable<out T, out TEnumerator> : IEnumerable<T>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        TEnumerator GetStructEnumerator();
    }
}
