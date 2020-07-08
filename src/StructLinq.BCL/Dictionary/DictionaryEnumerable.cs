using System.Collections.Generic;

namespace StructLinq.BCL.Dictionary
{
    public readonly struct DictionaryEnumerable<TKey, TValue> : IStructEnumerable<KeyValuePair<TKey, TValue>, DictionaryEnumerator<TKey, TValue>>
    {
        private readonly Dictionary<TKey, TValue> dictionary;
        private readonly DictionaryLayout<TKey, TValue> dictionaryLayout;

        public DictionaryEnumerable(Dictionary<TKey, TValue> dictionary)
        {
            this.dictionary = dictionary;
            dictionaryLayout = Unsafe.As<Dictionary<TKey, TValue>, DictionaryLayout<TKey, TValue>>(ref dictionary);
        }

        public DictionaryEnumerator<TKey, TValue> GetEnumerator()
        {
            return new DictionaryEnumerator<TKey, TValue>(dictionaryLayout.Entries, dictionary.Count);
        }
    }
}
