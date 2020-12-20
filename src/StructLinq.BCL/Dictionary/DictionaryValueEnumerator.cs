using System.Runtime.CompilerServices;

namespace StructLinq.BCL.Dictionary
{
    public struct DictionaryValueEnumerator<TKey, TValue> : ICollectionEnumerator<TValue>
    {
        private readonly Entry<TKey, TValue>[] entries;
        private readonly int length;
        private readonly int start;
        private int index;

        internal DictionaryValueEnumerator(Entry<TKey, TValue>[] entries, int start, int count)
        {
            this.entries = entries;
            length = count - 1 + start;
            index = start - 1;
            this.start = start;
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
            index = start-1;
        }

        public readonly TValue Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ref var entry = ref entries[index];
                return entry.Value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
        }
    }
}
