using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;
using StructLinq.Utils.Collections;

namespace StructLinq.Distinct
{
    public readonly struct DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> : IStructEnumerable<T,
            DistinctEnumerator<T, TEnumerator, TComparer>>
        where TComparer : IEqualityComparer<T>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>

    {
        private readonly TEnumerable enumerable;
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
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DistinctEnumerator<T, TEnumerator, TComparer> GetEnumerator()
        {
            var enumerator = enumerable.GetEnumerator();
            return new DistinctEnumerator<T, TEnumerator, TComparer>(ref enumerator, capacity, bucketPool, slotPool, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var distinctVisitor = new DistinctVisitor<T, TComparer, TVisitor>(capacity, bucketPool, slotPool, comparer, ref visitor);
            var visitStatus = enumerable.Visit(ref distinctVisitor);
            visitor = distinctVisitor.Visitor;
            distinctVisitor.Dispose();
            return visitStatus;
        }
    }
}