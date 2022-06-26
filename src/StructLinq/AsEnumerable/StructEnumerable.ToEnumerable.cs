using System.Runtime.CompilerServices;
using StructLinq.AsEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public readonly partial struct StructEnumerable<T, TEnumerable, TEnumerator>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromStructEnumerable<T,TEnumerator> ToEnumerable() 
        {
            return new EnumerableFromStructEnumerable<T, TEnumerator>(enumerable);
        }
    }

    public readonly partial struct StructCollection<T, TEnumerable, TEnumerator>
        where TEnumerable : IStructCollection<T, TEnumerator>
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromStructEnumerable<T,TEnumerator> ToEnumerable() 
        {
            return new EnumerableFromStructEnumerable<T, TEnumerator>(enumerable);
        }
    }


    public readonly partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
        where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromRefStructEnumerable<T, TEnumerator> ToEnumerable()
        {
            return new EnumerableFromRefStructEnumerable<T, TEnumerator>(enumerable);
        }
    }

    public readonly partial struct RefStructCollection<T, TEnumerable, TEnumerator>
        where TEnumerable : IRefStructCollection<T, TEnumerator>
        where TEnumerator : struct, IRefCollectionEnumerator<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromRefStructEnumerable<T, TEnumerator> ToEnumerable()
        {
            return new EnumerableFromRefStructEnumerable<T, TEnumerator>(enumerable);
        }
    }
}