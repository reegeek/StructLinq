namespace StructLinq
{
    public interface IStructCollection<out T, out TEnumerator> : IStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        int Count { get; }
    }
}
