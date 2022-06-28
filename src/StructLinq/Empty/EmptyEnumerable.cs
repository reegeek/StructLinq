using System.Runtime.CompilerServices;

namespace StructLinq.Empty
{
    public readonly struct EmptyEnumerable<T> : IStructEnumerable<T, EmptyEnumerator<T>>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly EmptyEnumerator<T> GetEnumerator()
        {
            return new();
        }

        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            return VisitStatus.EnumeratorFinished;
        }
    }
}
