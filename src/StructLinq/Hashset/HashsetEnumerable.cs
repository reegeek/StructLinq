#if !NETSTANDARD1_1
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Hashset
{
    public struct HashsetEnumerable<T> : IStructCollection<T, HashsetEnumerator<T>>
    {
        private readonly HashSet<T> hashset;
        private readonly HashsetLayout<T> hashsetLayout;
        private int count;
        private int start;
        
        internal HashsetEnumerable(HashSet<T> hashset, int start, int count)
        {
            this.hashset = hashset;
            hashsetLayout = UnsafeHelpers.As<HashSet<T>, HashsetLayout<T>>(ref hashset);
            this.count = count;
            this.start = start;
        }

        public HashsetEnumerable(HashSet<T> hashset) :
            this(hashset, 0, Int32.MaxValue)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly HashsetEnumerator<T> GetEnumerator()
        {
            return new HashsetEnumerator<T>(hashsetLayout.Entries, start, Count);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Max(0, MathHelpers.Min(hashset.Count, count) - start);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int) start + this.start;
                if (length.HasValue)
                    this.count = (int) length.Value + this.start;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
        {
            ref var entry = ref hashsetLayout.Entries[start + i];
            return entry.Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var count = Count;
            var s = start;
            var array = hashsetLayout.Entries;
            for (int i = 0; i < count; i++)
            {
                ref var input = ref array[s+i];
                if (!visitor.Visit(input.Value))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;

        }
    }
}
#endif