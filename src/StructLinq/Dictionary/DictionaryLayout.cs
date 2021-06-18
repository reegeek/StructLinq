#if !NETSTANDARD1_1
namespace StructLinq.Dictionary
{
    internal class DictionaryLayout<TKey, TValue>
    {
        public int[] Buckets;
        public Entry<TKey, TValue>[] Entries;
    }

#if (NET5_0_OR_GREATER)
    
    internal struct Entry<TKey, TValue>
    {
        public uint HashCode;
        public int Next;
        internal TKey Key;           // Key of entry
        internal TValue Value;         // Value of entry
    }
#elif NETCOREAPP3_0_OR_GREATER

    internal struct Entry<TKey, TValue>
    {
        public int Next;
        public uint HashCode;
        internal TKey Key;           // Key of entry
        internal TValue Value;         // Value of entry
    }
#else 
    internal struct Entry<TKey, TValue>
    {
        public int HashCode;
        public int Next;
        internal TKey Key;           // Key of entry
        internal TValue Value;         // Value of entry
    }
#endif
}
#endif