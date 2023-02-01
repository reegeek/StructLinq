using System.Runtime.CompilerServices;
using StructLinq.Empty;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmptyEnumerable<T> Empty<T>()
        {
            return new EmptyEnumerable<T>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollec<T, EmptyEnumerator<T>> Empty2<T>() => new(new());

    }
}
