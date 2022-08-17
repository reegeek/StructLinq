using System;
using System.Runtime.CompilerServices;
using StructLinq.Skip;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnumerable<T, SkipEnumerable<T, TEnumerable, TEnumerator>, SkipEnumerator<T, TEnumerator>> Skip(int count, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            return new(new(ref enumerable, count));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, SkipEnumerable<T, TEnumerable, TEnumerator>, SkipEnumerator<T, TEnumerator>> Skip(int count)
        {
            return new(new(ref enumerable, count));
        }
    }
}
