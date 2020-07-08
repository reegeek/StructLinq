using System.Runtime.CompilerServices;

namespace StructLinq.BCL.Dictionary
{
    public struct DictionaryValueEnumerator<TKey, TValue> : IStructEnumerator<TValue>
    {
        private readonly Entry<TKey, TValue>[] entries;
        private readonly int length;
        private int index;

        internal DictionaryValueEnumerator(Entry<TKey, TValue>[] entries, int count)
        {
            this.entries = entries;
            length = count - 1;
            index = -1;
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
