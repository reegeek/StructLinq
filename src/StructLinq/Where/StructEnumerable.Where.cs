using System;
using System.Runtime.CompilerServices;
using StructLinq.Where;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereEnumerable<T, TEnumerable, TEnumerator, TFunction> Where<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate, 
                                                                                                                            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunction : struct, IFunction<T, bool>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return new(ref predicate, ref enumerable);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereEnumerable<T, TEnumerable, TEnumerator> Where<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, 
                                                                                                                               Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return new(predicate, ref enumerable);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefWhereEnumerable<T, TEnumerable, TEnumerator, TFunction> Where<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate,
                                                                                                                               Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunction : struct, IInFunction<T, bool>
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        {
            return new(ref predicate, ref enumerable);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefWhereEnumerable<T, TEnumerable, TEnumerator, StructInFunction<T, bool>> Where<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, InFunc<T, bool> predicate,
                                                                                                                                    Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        {
            var structPredicate = predicate.ToStruct();
            return new(ref structPredicate, ref enumerable);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator> Where<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new(predicate, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefWhereEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator, StructInFunction<T, bool>> Where<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var structPredicate = predicate.ToStruct();
            return new(ref structPredicate, ref enumerable);
        }

    }
}
