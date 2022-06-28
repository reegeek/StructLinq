using System.Runtime.CompilerServices;
using StructLinq.AsEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromStructEnumerable<T,TEnumerator> ToEnumerable() 
        {
            return new(enumerable);
        }
    }

    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromStructEnumerable<T,TEnumerator> ToEnumerable() 
        {
            return new(enumerable);
        }
    }


    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromRefStructEnumerable<T, TEnumerator> ToEnumerable()
        {
            return new(enumerable);
        }
    }

    public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerableFromRefStructEnumerable<T, TEnumerator> ToEnumerable()
        {
            return new(enumerable);
        }
    }
}