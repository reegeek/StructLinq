using System.Collections.Generic;

namespace StructLinq
{
    public interface IStructEnumerable<T, out TEnumerator> : IEnumerable<T> 
        where TEnumerator : struct, IEnumerator<T>
    {
        TEnumerator GetStructEnumerator();
    }
}
