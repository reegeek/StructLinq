#if !NETSTANDARD1_1
// ReSharper disable once CheckNamespace

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.List;
using StructLinq.Utils;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public List<T> ToList()
        {
            var array = ToArray();
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public List<T> ToList(
            Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            var array = ToArray();
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