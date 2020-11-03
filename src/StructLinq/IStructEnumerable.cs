namespace StructLinq
{
    public interface IStructEnumerable<out T, out TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        TEnumerator GetEnumerator();

        void Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>;
    }
}
