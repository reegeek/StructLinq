// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Intersect;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool,
                ArrayPool<Slot<T>> slotPool,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool,
                ArrayPool<Slot<T>> slotPool)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, IEqualityComparer<T>>, IntersectEnumerator<T, TEnumerator, TEnumerator2, IEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                IEqualityComparer<T> comparer,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, EqualityComparer<T>>, IntersectEnumerator<T, TEnumerator, TEnumerator2, EqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new(new(ref enumerable, ref enumerable2.enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, EqualityComparer<T>>, IntersectEnumerator<T, TEnumerator, TEnumerator2, EqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                StructEnumerable<T, TEnumerable2, TEnumerator2> enumerable2)
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new(new(ref enumerable, ref enumerable2.enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
         StructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
         TComparer comparer,
         int capacity,
         ArrayPool<int> bucketPool,
         ArrayPool<Slot<T>> slotPool,
         Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
         Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
     where TComparer : IEqualityComparer<T>
     where TEnumerator2 : struct, ICollectionEnumerator<T>
     where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool,
                ArrayPool<Slot<T>> slotPool)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                int capacity)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, IntersectEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Intersect<TEnumerable2, TEnumerator2, TComparer>(
                StructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                TComparer comparer)
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, IEqualityComparer<T>>, IntersectEnumerator<T, TEnumerator, TEnumerator2, IEqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                StructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                IEqualityComparer<T> comparer,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new(new(ref enumerable, ref enumerable2.enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, EqualityComparer<T>>, IntersectEnumerator<T, TEnumerator, TEnumerator2, EqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                StructCollection<T, TEnumerable2, TEnumerator2> enumerable2,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new(new(ref enumerable, ref enumerable2.enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, IntersectEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, EqualityComparer<T>>, IntersectEnumerator<T, TEnumerator, TEnumerator2, EqualityComparer<T>>>
            Intersect<TEnumerable2, TEnumerator2>(
                StructCollection<T, TEnumerable2, TEnumerator2> enumerable2)
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new(new(ref enumerable, ref enumerable2.enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
        }
    }

}