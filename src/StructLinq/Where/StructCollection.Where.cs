using System;
using System.Runtime.CompilerServices;
using StructLinq.Where;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, WhereEnumerator<T, TEnumerator, TFunction>> Where<TFunction>(ref TFunction predicate)
            where TFunction : struct, IFunction<T, bool>
        {
            return ToStructEnumerable().Where(ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnum<T, WhereEnumerator<T, TEnumerator, TFunction>> Where<TFunction>(ref TFunction predicate, Func<TEnumerator, IStructEnumerator<T>> _)
            where TFunction : struct, IFunction<T, bool>
        {
            return ToStructEnumerable().Where(ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, WhereEnumerator<T, TEnumerator>> Where(Func<T, bool> predicate)
        {
            return ToStructEnumerable().Where(predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnum<T, WhereEnumerator<T, TEnumerator>> Where(Func<T, bool> predicate, Func<TEnumerator, IStructEnumerator<T>> _)
        {
            return ToStructEnumerable().Where(predicate);
        }
    }
}
