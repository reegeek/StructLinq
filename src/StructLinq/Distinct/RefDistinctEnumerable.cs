using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Distinct
{
    public struct RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> : IRefStructEnumerable<T,
        RefDistinctEnumerator<T, TEnumerator, TComparer>>
        where TComparer : IInEqualityComparer<T>
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TEnumerable : IRefStructEnumerable<T, TEnumerator>

    {
        private TEnumerable enumerable;
        private readonly TComparer comparer;
        private readonly int capacity;
        private readonly ArrayPool<int> bucketPool;
        private readonly ArrayPool<Slot<T>> slotPool;
        public RefDistinctEnumerable(ref TEnumerable enumerable, TComparer comparer, int capacity,
                                     ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool)
        {
            this.enumerable = enumerable;
            this.comparer = comparer;
            this.capacity = capacity;
            this.bucketPool = bucketPool;
            this.slotPool = slotPool;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefDistinctEnumerator<T, TEnumerator, TComparer> GetEnumerator()
        {
            var enumerator = enumerable.GetEnumerator();
            return new(ref enumerator, capacity, bucketPool, slotPool,
                                                                        comparer);
        }
    }
}
