#if !NETSTANDARD1_1
// ReSharper disable once CheckNamespace
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.List;
using StructLinq.Utils;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public List<T> ToList(int capacity, ArrayPool<T> pool)
        {
            var array = ToArray(capacity, pool);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public List<T> ToList(int capacity = 0)
        {
            return ToList(capacity, ArrayPool<T>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public List<T> ToList(int capacity, ArrayPool<T> pool, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var array = ToArray(capacity, pool);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }

    }
}
#endif