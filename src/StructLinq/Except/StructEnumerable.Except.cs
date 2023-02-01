// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Except;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>> Except<TEnumerator2, TComparer>(
            StructEnum<T, TEnumerator2> enumerable,
            TComparer comparer,
            int capacity,
            ArrayPool<int> bucketPool,
            ArrayPool<Slot<T>> slotPool) 
                where TEnumerator2 : struct, IStructEnumerator<T> 
                where TComparer : IEqualityComparer<T>
        {
            var copy = enumerator;
            var copy2 = enumerable.enumerator;
            return new(new(ref copy, ref copy2, comparer, capacity, bucketPool, slotPool));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>> Except<TEnumerator2, TComparer>(
            StructCollec<T, TEnumerator2> enumerable,
            TComparer comparer,
            int capacity,
            ArrayPool<int> bucketPool,
            ArrayPool<Slot<T>> slotPool)
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TComparer : IEqualityComparer<T>
        {
            var copy = enumerator;
            var copy2 = enumerable.enumerator;
            return new(new(ref copy, ref copy2, comparer, capacity, bucketPool, slotPool));
        }

    }

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructEnum<T, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>> Except<T, TEnumerator,
                TEnumerator2, TComparer>
            (this StructEnum<T, TEnumerator> enumerable1, StructEnum<T, TEnumerator2> enumerable2, TComparer comparer) 
                where TEnumerator : struct, IStructEnumerator<T> 
                where TEnumerator2 : struct, IStructEnumerator<T>
                where TComparer : IEqualityComparer<T>
        {
            return enumerable1.Except(enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructEnum<T, ExceptEnumerator<T, TEnumerator, TEnumerator2, EqualityComparer<T>>> Except<T, TEnumerator, TEnumerator2>
            (this StructEnum<T, TEnumerator> enumerable1, StructEnum<T, TEnumerator2> enumerable2)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return enumerable1.Except(enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

    }

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool, 
                ArrayPool<Slot<T>> slotPool,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            return new ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>(ref enumerable, ref enumerable2, comparer, capacity, bucketPool, slotPool); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                int capacity,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            return new ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>(ref enumerable, ref enumerable2, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            return new ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, IEqualityComparer<T>>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                IEqualityComparer<T> comparer,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            return new ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, IEqualityComparer<T>>(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, EqualityComparer<T>>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, EqualityComparer<T>>(ref enumerable, ref enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, IEqualityComparer<T>>
            Except<T, TEnumerator1, TEnumerator2>(
                this IStructEnumerable<T, TEnumerator1> enumerable,
                IStructEnumerable<T, TEnumerator2> enumerable2, 
                IEqualityComparer<T> comparer)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            return new ExceptEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, IEqualityComparer<T>>(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, EqualityComparer<T>>
            Except<T, TEnumerator1, TEnumerator2>(
                this IStructEnumerable<T, TEnumerator1> enumerable,
                IStructEnumerable<T, TEnumerator2> enumerable2)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new ExceptEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, EqualityComparer<T>>(ref enumerable, ref enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }
    }
}