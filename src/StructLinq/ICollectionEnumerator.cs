namespace StructLinq
{
    public interface ICollectionEnumerator<out T> : IStructEnumerator<T>
    {
        int Count { get; }
        T Get(int i); 
        void Slice(uint start, uint? length);
    }
}