using System;
using System.Runtime.CompilerServices;
using StructLinq.Where;
using StructLinq.WhereSelect;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TPredicate, TFunction> 
            Select<TIn, TOut, TEnumerable, TEnumerator, TPredicate, TFunction>(this WhereEnumerable<TIn, TEnumerable, TEnumerator, TPredicate> whereEnumerable,
                                                                               ref TFunction function, 
                                                                               Func<TEnumerable, IStructEnumerable<TIn, TEnumerator>> _,
                                                                               Func<TPredicate, IFunction<TIn, bool>> ___,
                                                                               Func<TFunction, IFunction<TIn, TOut>> __)
            where TEnumerator : struct, IStructEnumerator<TIn> 
            where TPredicate : struct, IFunction<TIn, bool>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructEnumerable<TIn, TEnumerator>
        {
            return new (ref function, ref whereEnumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereSelectEnumerable<TIn, TOut, IWhereEnumerable<TIn, TEnumerator>, TEnumerator>
            Select<TIn, TOut, TEnumerator>(this IWhereEnumerable<TIn, TEnumerator> whereEnumerable, Func<TIn, TOut> function)
            where TEnumerator : struct, IStructEnumerator<TIn>
        {
            return new(function, ref whereEnumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WhereSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator>
            Select<TIn, TOut, TEnumerable, TEnumerator>(this TEnumerable whereEnumerable,
                                                        Func<TIn, TOut> function,
                                                        Func<TEnumerable, IWhereEnumerable<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TEnumerable : IWhereEnumerable<TIn, TEnumerator>
        {
            return new(function, ref whereEnumerable);
        }


        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static WhereEnumerable<T, TEnumerable, TEnumerator> Where<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, 
        //                                                                                                                       Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        //    where TEnumerator : struct, IStructEnumerator<T>
        //    where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        //{
        //    return new WhereEnumerable<T, TEnumerable, TEnumerator>(predicate, ref enumerable);

        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static RefWhereEnumerable<T, TEnumerable, TEnumerator, TFunction> Where<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate,
        //                                                                                                                       Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        //    where TEnumerator : struct, IRefStructEnumerator<T>
        //    where TFunction : struct, IInFunction<T, bool>
        //    where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        //{
        //    return new RefWhereEnumerable<T, TEnumerable, TEnumerator, TFunction>(ref predicate, ref enumerable);
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static RefWhereEnumerable<T, TEnumerable, TEnumerator, StructInFunction<T, bool>> Where<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, InFunc<T, bool> predicate,
        //                                                                                                                            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        //    where TEnumerator : struct, IRefStructEnumerator<T>
        //    where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        //{
        //    var structPredicate = predicate.ToStruct();
        //    return new RefWhereEnumerable<T, TEnumerable, TEnumerator, StructInFunction<T, bool>>(ref structPredicate, ref enumerable);

        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static WhereEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator> Where<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
        //    where TEnumerator : struct, IStructEnumerator<T>
        //{
        //    return new WhereEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator>(predicate, ref enumerable);
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static RefWhereEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator, StructInFunction<T, bool>> Where<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, bool> predicate)
        //    where TEnumerator : struct, IRefStructEnumerator<T>
        //{
        //    var structPredicate = predicate.ToStruct();
        //    return new RefWhereEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator, StructInFunction<T, bool>>(ref structPredicate, ref enumerable);
        //}

    }
}
