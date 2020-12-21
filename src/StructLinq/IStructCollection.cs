namespace StructLinq
{
    public interface IStructCollection<out T, out TEnumerator> : IStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        int Count { get; }
        void Slice(uint start, uint? length);
        object Clone();
        T Get(int i);
    }
}
