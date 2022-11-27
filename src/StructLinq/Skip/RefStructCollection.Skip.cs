using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructCollec<T, TEnumerator> Skip(int count) => Slice((uint)count, null);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructCollec<T, TEnumerator> Skip(int count, Func<TEnumerator, IRefCollectionEnumerator<T>> _) => Skip(count);
    }
}