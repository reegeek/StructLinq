using System.Runtime.CompilerServices;
using StructLinq.AsEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public readonly partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromStructEnumerable<T,TEnumerator> ToEnumerable() 
        {
            return new EnumerableFromStructEnumerable<T, TEnumerator>(enumerable);
        }
    }

    public readonly partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromStructEnumerable<T,TEnumerator> ToEnumerable() 
        {
            return new EnumerableFromStructEnumerable<T, TEnumerator>(enumerable);
        }
    }


    public readonly partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromRefStructEnumerable<T, TEnumerator> ToEnumerable()
        {
            return new EnumerableFromRefStructEnumerable<T, TEnumerator>(enumerable);
        }
    }

    public readonly partial struct RefStructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromRefStructEnumerable<T, TEnumerator> ToEnumerable()
        {
            return new EnumerableFromRefStructEnumerable<T, TEnumerator>(enumerable);
        }
    }
}