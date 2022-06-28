﻿#if !NETSTANDARD1_1
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Array;
using StructLinq.Utils;

namespace StructLinq.List
{
    public struct ListRefEnumerable<T> : IRefStructCollection<T, ArrayRefStructEnumerator<T>>
    {
        private List<T> list;
        private ListLayout<T> layout;
        private int count;
        private int start;

        internal ListRefEnumerable(List<T> list, int start, int count)
        {
            this.list = list;
            layout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref list);
            this.start = start;
            this.count = count;
        }

        public ListRefEnumerable(List<T> list) : this(list, 0, Int32.MaxValue)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ArrayRefStructEnumerator<T> GetEnumerator()
        {
            return new(layout.Items, start, Count);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Max(0, MathHelpers.Min(list.Count, count) - start);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int)start + this.start;
                if (length.HasValue)
                    this.count = (int)length.Value + this.start;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T Get(int i)
        {
            return ref layout.Items[start + i];
        }
    }
}
#endif