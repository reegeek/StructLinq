// ReSharper disable once CheckNamespace

using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using StructLinq.IList;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<T, ListEnumerable<T, ImmutableArray<T>>, IListEnumerator<T,ImmutableArray<T>>> ToStructEnumerable<T>(this ImmutableArray<T> enumerable) 
        {
            return new (new(enumerable, 0, enumerable.Length));
        }

    }
}
