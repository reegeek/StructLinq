using System.Runtime.CompilerServices;
using StructLinq.Array;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArrayEnumerable<T> ToStructEnumerable<T>(this T[] array)
        {
            return new ArrayEnumerable<T>(array, 0, array.Length);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArrayRefEnumerable<T> ToRefStructEnumerable<T>(this T[] array)
        {
            return new ArrayRefEnumerable<T>(array, array.Length);
        }
    }
}
