

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public partial struct StructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any()
        {
            return enumerator.Count > 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any(Func<TEnumerator, IStructEnumerator<T>> _) => Any();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any(Func<T, bool> predicate) => ToStructEnumerable().Any(predicate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any(Func<T, bool> predicate, Func<TEnumerator, IStructEnumerator<T>> _) => ToStructEnumerable().Any(predicate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any<TFunction>(ref TFunction predicate) 
            where TFunction : struct, IFunction<T, bool>
            => ToStructEnumerable().Any(ref predicate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any<TFunction>(ref TFunction predicate, Func<TEnumerator, IStructEnumerator<T>> _)
            where TFunction : struct, IFunction<T, bool>
            => ToStructEnumerable().Any(ref predicate);
    }
}
