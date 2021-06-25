using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Except
{
    public struct ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer> : IStructEnumerable<T, ExceptEnumerator<T, TEnumerator1, TEnumerator2, TComparer>>
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

        internal ExceptEnumerable(ref TEnumerable1 enumerable1, ref TEnumerable2 enumerable2, TComparer comparer, int capacity,
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
        public ExceptEnumerator<T, TEnumerator1, TEnumerator2, TComparer> GetEnumerator()
        {
            var enum1 = enumerable1.GetEnumerator();
            var enum2 = enumerable2.GetEnumerator();
            return new ExceptEnumerator<T, TEnumerator1, TEnumerator2, TComparer>(ref enum1, ref  enum2, comparer, capacity, bucketPool, slotPool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var exceptVisitor = new ExceptVisitor<TVisitor>(capacity, bucketPool, slotPool, comparer, ref visitor);
            enumerable2.Visit(ref exceptVisitor);
            exceptVisitor.Add = false;
            var visitStatus = enumerable1.Visit(ref exceptVisitor);
            visitor = exceptVisitor.Visitor;
            exceptVisitor.Dispose();
            return visitStatus;
        }

        private struct ExceptVisitor<TVisitor> : IVisitor<T>
            where TVisitor : IVisitor<T>
        {
            public TVisitor Visitor;
            public bool Add;
            private PooledSet<T, TComparer> set;

            public ExceptVisitor(int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool, TComparer comparer, ref TVisitor visitor)
            {
                this.Visitor = visitor;
                set = new PooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
                Add = true;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                if (!Add)
                    return !set.AddIfNotPresent(input) || Visitor.Visit(input);
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
