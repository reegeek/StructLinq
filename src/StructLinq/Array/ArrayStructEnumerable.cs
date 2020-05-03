using StructLinq.Array;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static ArrayEnumerable<T> ToStructEnumerable<T>(this T[] array)
        {
            return new ArrayEnumerable<T>(array, array.Length);
        }
        public static ArrayRefEnumerable<T> ToRefStructEnumerable<T>(this T[] array)
        {
            return new ArrayRefEnumerable<T>(array, array.Length);
        }
    }
}
