using StructLinq.AsEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static AsIEnumerable<T, TEnumerator> ToEnumerable<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> structEnumerable) 
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new AsIEnumerable<T, TEnumerator>(structEnumerable);
        }
    }
}