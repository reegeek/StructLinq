namespace StructLinq
{
    public interface IRefCollectionEnumerator<T> : IRefStructEnumerator<T>
    {
        int Count { get; }
        ref T Get(int i); 
    }
}