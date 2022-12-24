

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any()
        {
            return enumerator.Count > 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any(Func<TEnumerator, IRefCollectionEnumerator<T>> _) => Any();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any(Func<T, bool> predicate) => ToRefStructEnumerable().Any(predicate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any(Func<T, bool> predicate, Func<TEnumerator, IRefCollectionEnumerator<T>> _) => ToRefStructEnumerable().Any(predicate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any<TFunction>(ref TFunction predicate) 
            where TFunction : struct, IInFunction<T, bool>
            => ToRefStructEnumerable().Any(ref predicate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any<TFunction>(ref TFunction predicate, Func<TEnumerator, IRefCollectionEnumerator<T>> _)
            where TFunction : struct, IInFunction<T, bool>
            => ToRefStructEnumerable().Any(ref predicate);
    }
}
