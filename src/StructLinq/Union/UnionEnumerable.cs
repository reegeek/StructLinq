using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;
using StructLinq.Utils.Collections;

namespace StructLinq.Union
{
    public readonly struct UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer> : IStructEnumerable<T, UnionEnumerator<T, TEnumerator1, TEnumerator2, TComparer>>
        where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
        where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        where TEnumerator1 : struct, IStructEnumerator<T>
        where TEnumerator2 : struct, IStructEnumerator<T>
        where TComparer : IEqualityComparer<T>
    {
        private readonly TEnumerable1 enumerable1;
        private readonly TEnumerable2 enumerable2;
        private readonly TComparer comparer;
        private readonly int capacity;
        private readonly ArrayPool<int> bucketPool;
        private readonly ArrayPool<Slot<T>> slotPool;

        internal UnionEnumerable(ref TEnumerable1 enumerable1, ref TEnumerable2 enumerable2, TComparer comparer, int capacity,
                                 ArrayPool<int> bucketPool, 
                                 ArrayPool<Slot<T>> slotPool)
        {
            this.enumerable1 = enumerable1;
            this.enumerable2 = enumerable2;
            this.comparer = comparer;
            this.capacity = capacity;
            this.bucketPool = bucketPool;
            this.slotPool = slotPool;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UnionEnumerator<T, TEnumerator1, TEnumerator2, TComparer> GetEnumerator()
        {
            var enum1 = enumerable1.GetEnumerator();
            var enum2 = enumerable2.GetEnumerator();
            var set = new PooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
            return new(ref enum1, ref  enum2, ref set);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var distinctVisitor = new DistinctVisitor<T, TComparer, TVisitor>(capacity, bucketPool, slotPool, comparer, ref visitor);
            var visitStatus = enumerable1.Visit(ref distinctVisitor);
            if (visitStatus != VisitStatus.VisitorFinished)
            {
                visitStatus = enumerable2.Visit(ref distinctVisitor);
            }
            visitor = distinctVisitor.Visitor;
            distinctVisitor.Dispose();
            return visitStatus;
        }
    }
}
