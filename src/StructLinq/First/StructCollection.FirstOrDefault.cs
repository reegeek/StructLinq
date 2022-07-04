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
        public T FirstOrDefault(Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            T first = default;
            TryFirst(ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T FirstOrDefault()
        {
            T first = default;
            TryFirst(ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T FirstOrDefault(Func<T, bool> predicate, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            T first = default;
            TryFirst(predicate, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T FirstOrDefault(Func<T, bool> predicate)
        {
            T first = default;
            TryFirst(predicate, ref first, x => x);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T FirstOrDefault<TFunc>(ref TFunc predicate, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            T first = default;
            TryFirst(ref predicate, ref first);
            return first;
        }
    }
}