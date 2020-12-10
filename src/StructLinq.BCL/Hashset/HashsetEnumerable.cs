using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.BCL.Hashset
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
            hashsetLayout = Unsafe.As<HashSet<T>, HashsetLayout<T>>(ref hashset);
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
    }
}
