using StructLinq.AsEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static EnumerableFromStructEnumerable<T,TEnumerator> ToEnumerable<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> structEnumerable) 
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new EnumerableFromStructEnumerable<T, TEnumerator>(structEnumerable);
        }
    }
}