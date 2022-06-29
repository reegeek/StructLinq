// ReSharper disable once CheckNamespace

#nullable enable
using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T[] ToArray(
            int capacity, 
            ArrayPool<T> pool,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var visitor = new PooledListVisitor<T>(capacity, pool);
            enumerable.Visit(ref visitor);
            var array = visitor.PooledList.ToArray();
            visitor.Dispose();
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray(
            int capacity = 0, 
            ArrayPool<T>? pool = null)
        {
            pool ??= ArrayPool<T>.Shared;
            var visitor = new PooledListVisitor<T>(capacity, pool);
            enumerable.Visit(ref visitor);
            var array = visitor.PooledList.ToArray();
            visitor.Dispose();
            return array;
        }
    }
}
