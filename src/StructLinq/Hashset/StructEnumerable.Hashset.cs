#if !NETSTANDARD1_1
using System.Runtime.CompilerServices;
using StructLinq.Hashset;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<T, HashsetEnumerable<T>, HashsetEnumerator<T>> ToStructEnumerable<T>(this System.Collections.Generic.HashSet<T> hashset)
        {
            return new (new(hashset));
        }
    }
}
#endif
