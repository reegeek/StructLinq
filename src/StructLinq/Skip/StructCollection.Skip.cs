using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructCollection<T, TEnumerable, TEnumerator> Skip(int count, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            var newCollection = enumerable;
            newCollection.Slice((uint)count, null);
            return new(newCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructCollection<T, TEnumerable, TEnumerator> Skip(int count)
        {
            var newCollection = enumerable;
            newCollection.Slice((uint)count, null);
            return new(newCollection);
        }

    }
}