

// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Reverse;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReverseEnumerable<T, TEnumerable, TEnumerator> Reverse<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable, 
            int capacity, 
            ArrayPool<T> pool,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new ReverseEnumerable<T, TEnumerable, TEnumerator>(enumerable, capacity, pool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReverseEnumerable<T, TEnumerable, TEnumerator> Reverse<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new ReverseEnumerable<T, TEnumerable, TEnumerator>(enumerable, 0, ArrayPool<T>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReverseEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator> Reverse<T, TEnumerator>(
            this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new ReverseEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator>(enumerable, 0, ArrayPool<T>.Shared);
        }

    }
}
