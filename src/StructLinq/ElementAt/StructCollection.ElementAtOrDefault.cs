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
        public T ElementAtOrDefault(int index, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            T elementAt = default;
            if (TryElementAt(ref elementAt, index))
                return elementAt;
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T ElementAtOrDefault(int index)
        {
            T elementAt = default;
            if (TryElementAt(ref elementAt, index))
                return elementAt;
            return default;
        }
    }

}