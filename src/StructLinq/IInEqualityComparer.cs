namespace StructLinq
{
    public interface IInEqualityComparer<T>
    {
        bool Equals(in T x, in T y);

        int GetHashCode(in T obj);
    }
}
