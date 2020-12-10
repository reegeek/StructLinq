// ReSharper disable once CheckNamespace

using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using StructLinq.IList;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class BCLStructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IListEnumerable<T, ImmutableArray<T>> ToStructEnumerable<T>(this ImmutableArray<T> enumerable) 
        {
            return new IListEnumerable<T, ImmutableArray<T>>(enumerable, 0, enumerable.Length);
        }

    }
}
