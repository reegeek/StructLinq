#if !NETSTANDARD1_1
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Dictionary;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<KeyValuePair<TKey, TValue>, DictionaryEnumerable<TKey, TValue>, DictionaryEnumerator<TKey, TValue>> ToStructEnumerable<TKey, TValue>(this System.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            return new(new(dictionary));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<TValue, DictionaryValueEnumerable<TKey, TValue>, DictionaryValueEnumerator<TKey, TValue>> ToStructValueEnumerable<TKey, TValue>(this System.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            return new(new(dictionary));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<TKey, DictionaryKeyEnumerable<TKey, TValue>, DictionaryKeyEnumerator<TKey, TValue>> ToStructKeyEnumerable<TKey, TValue>(this System.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            return new(new(dictionary));
        }

    }
}
#endif
