using System.Runtime.CompilerServices;

namespace StructLinq
{
    public readonly partial struct StructEnum<T, TEnumerator>
    where TEnumerator : struct, IStructEnumerator<T>
    {
        private readonly TEnumerator enumerator;

        public StructEnum(TEnumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator() => enumerator;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            return enumerator.Visit(ref visitor);
        }
    }


    public interface IStructEnumerable<out T, out TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        TEnumerator GetEnumerator();

        VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>;
    }
}
