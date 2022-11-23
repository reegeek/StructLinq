using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using StructLinq.Utils;
using StructLinq.Utils.Collections;

namespace StructLinq.Distinct
{
    public struct DistinctEnumerator<T, TEnumerator, TComparer> : IStructEnumerator<T>
        where TEnumerator : struct, IStructEnumerator<T>
        where TComparer : IEqualityComparer<T>
    {
        private TEnumerator enumerator;
        private readonly int capacity;
        private readonly ArrayPool<int> bucketPool;
        private readonly ArrayPool<Slot<T>> slotPool;
        private readonly TComparer comparer;
        private PooledSet<T, TComparer> set;
        public DistinctEnumerator(ref TEnumerator enumerator, int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool, TComparer comparer)
        {
            this.enumerator = enumerator;
            this.capacity = capacity;
            this.bucketPool = bucketPool;
            this.slotPool = slotPool;
            this.comparer = comparer;
            set = new PooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (set.AddIfNotPresent(current))
                    return true;
            }
            return false;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
            set.Clear();
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            set.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var distinctVisitor = new DistinctVisitor<T, TComparer, TVisitor>(capacity, bucketPool, slotPool, comparer, ref visitor);
            var visitStatus = enumerator.Visit(ref distinctVisitor);
            visitor = distinctVisitor.Visitor;
            distinctVisitor.Dispose();
            return visitStatus;
        }

    }
}