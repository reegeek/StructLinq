using System.Runtime.CompilerServices;
using StructLinq.Repeat;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RepeatEnumerable<T> Repeat<T>(T element, uint count)
        {
            return new(element, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T>(RepeatEnumerable<T> repeatEnumerable)
        {
            return (int)repeatEnumerable.Count;
        }
    }
}
