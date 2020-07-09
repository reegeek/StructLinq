using System.Buffers;
using System.Collections.Generic;
using StructLinq.Utils.Collections;

namespace StructLinq.Distinct
{
    public struct DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> : IStructEnumerable<T,
            DistinctEnumerator<T, TEnumerator, TComparer>>
        where TComparer : IEqualityComparer<T>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>

    {
        private TEnumerable enumerable;
        private readonly TComparer comparer;
        private readonly int capacity;
        private readonly ArrayPool<int> bucketPool;
        private readonly ArrayPool<Slot<T>> slotPool;
        public DistinctEnumerable(ref TEnumerable enumerable, TComparer comparer, int capacity,
            ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool)
        {
            this.enumerable = enumerable;
            this.comparer = comparer;
            this.capacity = capacity;
            this.bucketPool = bucketPool;
            this.slotPool = slotPool;
        }
        public DistinctEnumerator<T, TEnumerator, TComparer> GetEnumerator()
        {
            var enumerator = enumerable.GetEnumerator();
            return new DistinctEnumerator<T, TEnumerator, TComparer>(ref enumerator, capacity, bucketPool, slotPool,
                comparer);
        }
    }
}