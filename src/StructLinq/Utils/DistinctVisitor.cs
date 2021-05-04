using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Utils
{
    internal struct DistinctVisitor<T, TComparer, TVisitor> : IVisitor<T>
        where TComparer : IEqualityComparer<T>
        where TVisitor : IVisitor<T>
    {
        public TVisitor Visitor;
        private PooledSet<T, TComparer> set;

        public DistinctVisitor(int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool, TComparer comparer, ref TVisitor visitor)
        {
            this.Visitor = visitor;
            set = new PooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            return !set.AddIfNotPresent(input) || Visitor.Visit(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            set.Dispose();
        }
    }
}