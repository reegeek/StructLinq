namespace StructLinq
{
    public interface IStructEnumerable<out T, out TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        TEnumerator GetStructEnumerator();
    }
}
