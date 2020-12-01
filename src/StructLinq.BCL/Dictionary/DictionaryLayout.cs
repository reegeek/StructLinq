namespace StructLinq.BCL.Dictionary
{
    internal class DictionaryLayout<TKey, TValue>
    {
        public int[] Buckets;
        public Entry<TKey, TValue>[] Entries;
    }

#if (NETCOREAPP3_0 || NETCOREAPP3_1)
    
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
