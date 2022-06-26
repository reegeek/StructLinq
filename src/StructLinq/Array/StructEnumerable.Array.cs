using System.Runtime.CompilerServices;
using StructLinq.Array;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<T, ArrayEnumerable<T>, ArrayStructEnumerator<T>> ToStructEnumerable<T>(this T[] array)
        {
            return new StructCollection<T, ArrayEnumerable<T>, ArrayStructEnumerator<T>>(new ArrayEnumerable<T>(array, 0, array.Length));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefStructCollection<T, ArrayRefEnumerable<T>, ArrayRefStructEnumerator<T>> ToRefStructEnumerable<T>(this T[] array)
        {
            return new RefStructCollection<T, ArrayRefEnumerable<T>, ArrayRefStructEnumerator<T>>(new ArrayRefEnumerable<T>(array, 0, array.Length));
        }

    }
}
