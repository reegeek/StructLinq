namespace StructLinq.BCL.Dictionary
{
    internal class DictionaryLayout<TKey, TValue>
    {
        public int[] Buckets;
        public Entry<TKey, TValue>[] Entries;
    }

#if (NET452 || NETCOREAPP1_0 || NETCOREAPP2_0 || NETCOREAPP2_1 || NETCOREAPP2_2)
    internal struct Entry<TKey, TValue>
    {
        public int HashCode;
        public int Next;
        internal TKey Key;           // Key of entry
        internal TValue Value;         // Value of entry
    }
#endif
#if (NETCOREAPP3_0 || NETCOREAPP3_1)
    
    internal struct Entry<TKey, TValue>
    {
        public int Next;
        public uint HashCode;
        internal TKey Key;           // Key of entry
        internal TValue Value;         // Value of entry
    }
#endif
#if (NET5_0)
    
    internal struct Entry<TKey, TValue>
    {
        public uint HashCode;
        public int Next;
        internal TKey Key;           // Key of entry
        internal TValue Value;         // Value of entry
    }
#endif
}
