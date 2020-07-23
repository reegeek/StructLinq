using System.Collections.Generic;

namespace StructLinq.BCL.Dictionary
{
    public readonly struct DictionaryKeyEnumerable<TKey, TValue> : IStructCollection<TKey, DictionaryKeyEnumerator<TKey, TValue>>
    {
        private readonly Dictionary<TKey, TValue> dictionary;
        private readonly DictionaryLayout<TKey, TValue> dictionaryLayout;

        public DictionaryKeyEnumerable(Dictionary<TKey, TValue> dictionary)
        {
            this.dictionary = dictionary;
            dictionaryLayout = Unsafe.As<Dictionary<TKey, TValue>, DictionaryLayout<TKey, TValue>>(ref dictionary);
        }

        public DictionaryKeyEnumerator<TKey, TValue> GetEnumerator()
        {
            return new DictionaryKeyEnumerator<TKey, TValue>(dictionaryLayout.Entries, dictionary.Count);
        }

        public int Count => dictionary.Count;
    }
}
