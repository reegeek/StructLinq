using StructLinq.Array;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static ArrayEnumerable<T> ToTypedEnumerable<T>(this T[] array) where T : struct
        {
            return new ArrayEnumerable<T>(array, array.Length - 1);
        }
        public static RefArrayEnumerable<T> ToRefTypedEnumerable<T>(this T[] array) where T : class
        {
            return new RefArrayEnumerable<T>(array, array.Length - 1);
        }
    }
}
