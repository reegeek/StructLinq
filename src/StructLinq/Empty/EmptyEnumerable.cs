using System.Runtime.CompilerServices;

namespace StructLinq.Empty
{
    public struct EmptyEnumerable<T> : IStructEnumerable<T, EmptyEnumerator<T>>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly EmptyEnumerator<T> GetEnumerator()
        {
            return new EmptyEnumerator<T>();
        }

        public void Visit<TVisitor>(TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            
        }
    }
}
