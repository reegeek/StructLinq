using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.BCL.Dictionary
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
            dictionaryLayout = Unsafe.As<Dictionary<TKey, TValue>, DictionaryLayout<TKey, TValue>>(ref dictionary);
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
            get => MathHelpers.Min(dictionary.Count, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint length)
        {
            this.start = (int)start + this.start;
            this.count = (int)length + this.start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return new DictionaryEnumerable<TKey, TValue>(dictionary, start, count);
        }

    }
}
