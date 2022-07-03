﻿// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T ElementAtOrDefault(int index, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            T elementAt = default;
            if (TryInnerElementAt(ref enumerator, ref elementAt, index))
                return elementAt;
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T ElementAtOrDefault(int index)
        {
            var enumerator = enumerable.GetEnumerator();
            T elementAt = default;
            if (TryInnerElementAt(ref enumerator, ref elementAt, index))
                return elementAt;
            return default;
        }
    }

}