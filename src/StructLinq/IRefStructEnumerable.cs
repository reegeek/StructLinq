namespace StructLinq
{
    public interface IRefStructEnumerable<out T, out TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        TEnumerator GetEnumerator();
    }
}