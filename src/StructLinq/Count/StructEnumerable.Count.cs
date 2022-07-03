

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;
using StructLinq.Count;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count()
        {
            var visitor = new IntCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public int Count(Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            return Count();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long LongCount()
        {
            var visitor = new LongCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public long LongCount(Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            return LongCount();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UIntCount()
        {
            var visitor = new UIntCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public uint UIntCount(Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            return UIntCount();
        }

    }
}
