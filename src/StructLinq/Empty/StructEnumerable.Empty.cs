using System.Runtime.CompilerServices;
using StructLinq.Empty;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructEnumerable<T, EmptyEnumerable<T>, EmptyEnumerator<T>> Empty<T>()
        {
            return new(new ());
        }
    }
}
