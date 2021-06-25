using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;
using StructLinq.Utils.Collections;

namespace StructLinq.Union
{
    public struct UnionEnumerator<T, TEnumerator1, TEnumerator2, TComparer> : IStructEnumerator<T>
        where TEnumerator1 : struct, IStructEnumerator<T>
        where TEnumerator2 : struct, IStructEnumerator<T>
        where TComparer : IEqualityComparer<T>
    {
        private TEnumerator1 enumerator1;
        private TEnumerator2 enumerator2;
        private readonly TComparer comparer;
        private readonly int capacity;
        private readonly ArrayPool<int> bucketPool;
        private readonly ArrayPool<Slot<T>> slotPool;
        private PooledSet<T, TComparer> set;
        private bool first;

        internal UnionEnumerator(ref TEnumerator1 enumerator1, ref TEnumerator2 enumerator2, TComparer comparer, int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool)
            : this()
        {
            this.enumerator1 = enumerator1;
            this.enumerator2 = enumerator2;
            this.comparer = comparer;
            this.capacity = capacity;
            this.bucketPool = bucketPool;
            this.slotPool = slotPool;
            set = new PooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
            first = true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            set.Dispose();
            enumerator1.Dispose();
            enumerator2.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (first)
            {
                while (enumerator1.MoveNext())
                {
                    var current = enumerator1.Current;
                    if (set.AddIfNotPresent(current))
                        return true;
                }
            }

            first = false;
            while (enumerator2.MoveNext())
            {
                var current = enumerator2.Current;
                if (set.AddIfNotPresent(current))
                    return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            set.Clear();
            enumerator1.Reset();
            enumerator2.Reset();
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => first ? enumerator1.Current : enumerator2.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var distinctVisitor = new DistinctVisitor<T, TComparer, TVisitor>(capacity, bucketPool, slotPool, comparer, ref visitor);
            var visitStatus = enumerator1. Visit(ref distinctVisitor);
            if (visitStatus != VisitStatus.VisitorFinished)
            {
                visitStatus = enumerator2.Visit(ref distinctVisitor);
            }
            visitor = distinctVisitor.Visitor;
            distinctVisitor.Dispose();
            return visitStatus;
        }


    }
}
