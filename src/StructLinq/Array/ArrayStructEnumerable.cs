using StructLinq.Array;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static ITypedEnumerable<T,ArrayStructEnumerator<T>> ToTypedEnumerable<T>(this T[] array)
        {
            return new ArrayEnumerable<T>(ref array);
        }
    }
}
