// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Intersect;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool,
                ArrayPool<Slot<T>> slotPool,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool,
                ArrayPool<Slot<T>> slotPool)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, IInEqualityComparer<T>>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, IInEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                IInEqualityComparer<T> comparer,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, IInEqualityComparer<T>>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, IInEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                IInEqualityComparer<T> comparer)
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, StructInEqualityComparer<T>>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, StructInEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            var equalityComparer = InEqualityComparer<T>.Default;
            return new(new(ref enumerable, ref enumerable2.enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, StructInEqualityComparer<T>>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, StructInEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                RefStructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2)
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        {
            var equalityComparer = InEqualityComparer<T>.Default;
            return new(new(ref enumerable, ref enumerable2.enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }





        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool,
                ArrayPool<Slot<T>> slotPool,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructCollection<T, TEnumerator2>> __)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool,
                ArrayPool<Slot<T>> slotPool)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructCollection<T, TEnumerator2>> __)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructCollection<T, TEnumerator2>> __)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, IInEqualityComparer<T>>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, IInEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                IInEqualityComparer<T> comparer,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, IInEqualityComparer<T>>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, IInEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                IInEqualityComparer<T> comparer)
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove two last arguments")]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, StructInEqualityComparer<T>>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, StructInEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IRefStructCollection<T, TEnumerator2>> __)
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            var equalityComparer = InEqualityComparer<T>.Default;
            return new(new(ref enumerable, ref enumerable2.enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefIntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, StructInEqualityComparer<T>>, RefIntersectEnumerator<T, TEnumerator, TEnumerator2, StructInEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                RefStructCollection<T, TEnumerable2, TEnumerator2> enumerable2)
            where TEnumerator2 : struct, IRefCollectionEnumerator<T>
            where TEnumerable2 : struct, IRefStructCollection<T, TEnumerator2>
        {
            var equalityComparer = InEqualityComparer<T>.Default;
            return new(new(ref enumerable, ref enumerable2.enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

    }

}