namespace StructLinq
{
    public interface IStructEnumerable<T, out TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        TEnumerator GetEnumerator();
    }
}
