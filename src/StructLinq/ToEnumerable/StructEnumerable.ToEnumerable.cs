using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerableEnumerable<T, TEnumerator> ToEnumerable() => new(this);
    }
}
