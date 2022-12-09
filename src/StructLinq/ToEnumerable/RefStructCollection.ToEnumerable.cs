using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerableEnumerable<T, TEnumerator> ToEnumerable() => ToRefStructEnumerable().ToEnumerable();
    }
}
