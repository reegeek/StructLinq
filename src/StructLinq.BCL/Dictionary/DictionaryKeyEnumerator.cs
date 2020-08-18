using System.Runtime.CompilerServices;

namespace StructLinq.BCL.Dictionary
{
    public struct DictionaryKeyEnumerator<TKey, TValue> : IStructEnumerator<TKey>
    {
        private readonly Entry<TKey, TValue>[] entries;
        private readonly int length;
        private int index;

        internal DictionaryKeyEnumerator(Entry<TKey, TValue>[] entries, int start, int count)
        {
            this.entries = entries;
            length = count - 1;
            index = start - 1;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (++index <= length)
            {
                ref var entry = ref entries[index];
                if (entry.Next >= -1)
                    return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }

        public readonly TKey Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ref var entry = ref entries[index];
                return entry.Key;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
        }
    }
}
