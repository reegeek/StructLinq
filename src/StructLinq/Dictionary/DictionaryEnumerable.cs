﻿#if !NETSTANDARD1_1
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Dictionary
{
    public struct DictionaryEnumerable<TKey, TValue> : IStructCollection<KeyValuePair<TKey, TValue>, DictionaryEnumerator<TKey, TValue>>
    {
        private readonly Dictionary<TKey, TValue> dictionary;
        private readonly DictionaryLayout<TKey, TValue> dictionaryLayout;
        private int count;
        private int start;
        
        internal DictionaryEnumerable(Dictionary<TKey, TValue> dictionary, int start, int count)
        {
            this.dictionary = dictionary;
            dictionaryLayout = UnsafeHelpers.As<Dictionary<TKey, TValue>, DictionaryLayout<TKey, TValue>>(ref dictionary);
            this.count = count;
            this.start = start;
        }

        public DictionaryEnumerable(Dictionary<TKey, TValue> dictionary) :
            this(dictionary, 0, Int32.MaxValue)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly DictionaryEnumerator<TKey, TValue> GetEnumerator()
        {
            return new DictionaryEnumerator<TKey, TValue>(dictionaryLayout.Entries, start, Count);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Max(0, MathHelpers.Min(dictionary.Count, count) - start);
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
        public KeyValuePair<TKey, TValue> Get(int i)
        {
            ref var entry = ref dictionaryLayout.Entries[start + i];
            return new KeyValuePair<TKey, TValue>(entry.Key, entry.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<KeyValuePair<TKey, TValue>>
        {
            var count = Count;
            var s = start;
            var array = dictionaryLayout.Entries;
            for (int i = 0; i < count; i++)
            {
                ref var input = ref array[s+i];
                if (!visitor.Visit(new KeyValuePair<TKey, TValue>(input.Key, input.Value)))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }
    }
}
#endif