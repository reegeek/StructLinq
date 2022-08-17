using System;
using System.Runtime.CompilerServices;
using StructLinq.Take;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnumerable<T, TakeEnumerable<T, TEnumerable, TEnumerator>, TakeEnumerator<T, TEnumerator>>  Take(int count, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            return new (new(ref enumerable, count));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, TakeEnumerable<T, TEnumerable, TEnumerator>, TakeEnumerator<T, TEnumerator>> Take(int count)
        {
            return new(new(ref enumerable, count));
        }

    }
}
