// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructCollec<T, TEnumerator> Take(int count) => Slice(0, (uint)count);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructCollec<T, TEnumerator> Take(int count, Func<TEnumerator, IRefCollectionEnumerator<T>> _) => Take(count);
    }
    
}