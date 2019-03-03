using StructLinq.Array;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static ITypedEnumerable<T,ArrayStructEnumerator<T>> SafeToTypedEnumerable<T>(this T[] array)
        {
            return new ArrayEnumerable<T>(ref array);
        }
        public static ITypedEnumerable<T, UnmanagedArrayEnumerator<T>> ToTypedEnumerable<T>(this T[] array) where T : unmanaged
        {
            return new UnmanagedArrayEnumerable<T>(ref array);
        }
    }
}
