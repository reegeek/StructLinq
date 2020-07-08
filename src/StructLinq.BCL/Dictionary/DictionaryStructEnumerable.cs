using System.Runtime.CompilerServices;
using StructLinq.BCL.Dictionary;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class BCLStructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DictionaryEnumerable<TKey, TValue> ToStructEnumerable<TKey, TValue>(this System.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            return new DictionaryEnumerable<TKey, TValue>(dictionary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DictionaryValueEnumerable<TKey, TValue> ToStructValueEnumerable<TKey, TValue>(this System.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            return new DictionaryValueEnumerable<TKey, TValue>(dictionary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DictionaryKeyEnumerable<TKey, TValue> ToStructKeyEnumerable<TKey, TValue>(this System.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            return new DictionaryKeyEnumerable<TKey, TValue>(dictionary);
        }

    }
}
