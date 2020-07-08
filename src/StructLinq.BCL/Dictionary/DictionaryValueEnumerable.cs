using System.Collections.Generic;

namespace StructLinq.BCL.Dictionary
{
    public readonly struct DictionaryValueEnumerable<TKey, TValue> : IStructEnumerable<TValue, DictionaryValueEnumerator<TKey, TValue>>
    {
        private readonly Dictionary<TKey, TValue> dictionary;
        private readonly DictionaryLayout<TKey, TValue> dictionaryLayout;

        public DictionaryValueEnumerable(Dictionary<TKey, TValue> dictionary)
        {
            this.dictionary = dictionary;
            dictionaryLayout = Unsafe.As<Dictionary<TKey, TValue>, DictionaryLayout<TKey, TValue>>(ref dictionary);
        }

        public DictionaryValueEnumerator<TKey, TValue> GetEnumerator()
        {
            return new DictionaryValueEnumerator<TKey, TValue>(dictionaryLayout.Entries, dictionary.Count);
        }
    }
}
