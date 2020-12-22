namespace StructLinq
{
    public interface IDirectStructCollection<out T, out TEnumerator> : IStructCollection<T, TEnumerator>
        where TEnumerator : struct, ICollectionEnumerator<T>
    {

    }
}