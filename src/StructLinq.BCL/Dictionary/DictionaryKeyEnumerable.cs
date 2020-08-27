using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.BCL.Dictionary
{
    public struct DictionaryKeyEnumerable<TKey, TValue> : IStructCollection<TKey, DictionaryKeyEnumerator<TKey, TValue>>
    {
        private readonly Dictionary<TKey, TValue> dictionary;
        private readonly DictionaryLayout<TKey, TValue> dictionaryLayout;
        private int count;
        private int start;

        internal DictionaryKeyEnumerable(Dictionary<TKey, TValue> dictionary, int start, int count)
        {
            this.dictionary = dictionary;
            dictionaryLayout = Unsafe.As<Dictionary<TKey, TValue>, DictionaryLayout<TKey, TValue>>(ref dictionary);
            this.start = start;
            this.count = count;
        }

        public DictionaryKeyEnumerable(Dictionary<TKey, TValue> dictionary) :
            this(dictionary, 0, Int32.MaxValue)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly DictionaryKeyEnumerator<TKey, TValue> GetEnumerator()
        {
            return new DictionaryKeyEnumerator<TKey, TValue>(dictionaryLayout.Entries, start, Count);
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
            return new DictionaryKeyEnumerable<TKey, TValue>(dictionary, start, count);
        }

    }
}
