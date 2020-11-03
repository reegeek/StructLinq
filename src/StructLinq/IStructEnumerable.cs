namespace StructLinq
{
    public interface IStructEnumerable<out T, out TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        TEnumerator GetEnumerator();

        void Visit<TVisitor>(TVisitor visitor)
            where TVisitor : IVisitor<T>;
    }
}
