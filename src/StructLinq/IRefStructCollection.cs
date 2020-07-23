namespace StructLinq
{
    public interface IRefStructCollection<out T, out TEnumerator> : IRefStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        int Count { get; }
    }
}
