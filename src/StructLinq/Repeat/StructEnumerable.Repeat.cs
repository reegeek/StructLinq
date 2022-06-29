using System.Runtime.CompilerServices;
using StructLinq.Repeat;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<T, RepeatEnumerable<T>, RepeatEnumerator<T>> Repeat<T>(T element, uint count)
        {
            return new(new(element, count));
        }
    }
}
