

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public int Count(Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            return enumerable.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count()
        {
            return enumerable.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public uint UIntCount(Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            return (uint)enumerable.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UIntCount()
        {
            return (uint)enumerable.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public long LongCount(Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            return enumerable.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long LongCount()
        {
            return enumerable.Count;
        }

    }
}
