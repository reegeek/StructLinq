using System;
using System.Runtime.CompilerServices;
using StructLinq.Where;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnumerable<T, WhereEnumerable<T, TEnumerable, TEnumerator, TFunction>, WhereEnumerator<T, TEnumerator, TFunction>>
            Where<TFunction>(ref TFunction predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunction : struct, IFunction<T, bool>
        {
            return new(new(ref predicate, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnumerable<T, WhereEnumerable<T, TEnumerable, TEnumerator>, WhereEnumerator<T, TEnumerator>>
            Where(Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            return new(new(predicate, ref enumerable));

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, WhereEnumerable<T, TEnumerable, TEnumerator, TFunction>, WhereEnumerator<T, TEnumerator, TFunction>>
            Where<TFunction>(ref TFunction predicate)
            where TFunction : struct, IFunction<T, bool>
        {
            return new(new(ref predicate, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, WhereEnumerable<T, TEnumerable, TEnumerator>, WhereEnumerator<T, TEnumerator>>
            Where(Func<T, bool> predicate)
        {
            return new(new(predicate, ref enumerable));

        }
    }
}
