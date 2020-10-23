namespace StructLinq
{
    public interface IRefStructCollection<T, out TEnumerator> : IRefStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        int Count { get; }
        void Slice(uint start, uint? length);
        object Clone();

        ref T Get(int i);
    }
}
