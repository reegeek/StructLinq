﻿using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Intersect
{
    public struct IntersectEnumerator<T, TEnumerator1, TEnumerator2, TComparer> : IStructEnumerator<T>
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

        internal IntersectEnumerator(ref TEnumerator1 enumerator1, ref TEnumerator2 enumerator2, TComparer comparer, int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool)
            : this()
        {
            this.enumerator1 = enumerator1;
            this.enumerator2 = enumerator2;
            this.comparer = comparer;
            this.capacity = capacity;
            this.bucketPool = bucketPool;
            this.slotPool = slotPool;
            set = new PooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
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
            while (enumerator1.MoveNext())
            {
                var current = enumerator1.Current;
                set.AddIfNotPresent(current);
            }
            while (enumerator2.MoveNext())
            {
                var current = enumerator2.Current;
                if (set.Remove(current))
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
            get => enumerator2.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var exceptVisitor = new IntersectVisitor<TVisitor>(capacity, bucketPool, slotPool, comparer, ref visitor);
            enumerator1.Visit(ref exceptVisitor);
            exceptVisitor.Add = false;
            var visitStatus = enumerator2.Visit(ref exceptVisitor);
            visitor = exceptVisitor.Visitor;
            exceptVisitor.Dispose();
            return visitStatus;
        }

        private struct IntersectVisitor<TVisitor> : IVisitor<T>
            where TVisitor : IVisitor<T>
        {
            public TVisitor Visitor;
            public bool Add;
            private PooledSet<T, TComparer> set;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public IntersectVisitor(int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool, TComparer comparer, ref TVisitor visitor)
            {
                Visitor = visitor;
                set = new PooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
                Add = true;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                if (!Add)
                    return set.Remove(input) && Visitor.Visit(input);
                set.AddIfNotPresent(input);
                return true;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Dispose()
            {
                set.Dispose();
            }
        }
    }
}
