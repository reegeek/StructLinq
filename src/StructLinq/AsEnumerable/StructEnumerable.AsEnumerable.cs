using System.Runtime.CompilerServices;
using StructLinq.AsEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EnumerableFromStructEnumerable<T,TEnumerator> ToEnumerable<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> structEnumerable) 
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new EnumerableFromStructEnumerable<T, TEnumerator>(structEnumerable);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EnumerableFromRefStructEnumerable<T, TEnumerator> ToEnumerable<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> structEnumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return new EnumerableFromRefStructEnumerable<T, TEnumerator>(structEnumerable);
        }

    }
}