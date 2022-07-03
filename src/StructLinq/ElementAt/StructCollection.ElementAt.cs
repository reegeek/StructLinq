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
        public T ElementAt(int index, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (index >= enumerable.Count || index < 0)
                throw new ArgumentOutOfRangeException("index");
            return enumerable.Get(index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T ElementAt(int index)
        {
            if (index >= enumerable.Count  || index < 0)
                throw new ArgumentOutOfRangeException("index");
            return enumerable.Get(index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryElementAt(ref T elementAt, int index, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (index >= enumerable.Count || index < 0)
                return false;
            elementAt = enumerable.Get(index);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryElementAt(ref T elementAt, int index)
        {
            if (index >= enumerable.Count || index < 0)
                return false;
            elementAt = enumerable.Get(index);
            return true;
        }

    }
}