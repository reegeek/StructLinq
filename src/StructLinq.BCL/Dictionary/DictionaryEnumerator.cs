using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.BCL.Dictionary
{
    public struct DictionaryEnumerator<TKey, TValue> : IStructEnumerator<KeyValuePair<TKey, TValue>>
    {
        private readonly Entry<TKey, TValue>[] entries;
        private readonly int length;
        private int index;

        internal DictionaryEnumerator(Entry<TKey, TValue>[] entries, int start, int count)
        {
            this.entries = entries;
            length = count - 1;
            index = start -1;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (++index <= length)
            {
                ref var entry = ref entries[index];
#if (NETCOREAPP3_0 )
                if (entry.Next >= -1)
#endif
#if (NET452 || NETCOREAPP1_0 || NETCOREAPP2_0)
                if (entry.HashCode >= 0)
#endif
                    return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }

        public readonly KeyValuePair<TKey, TValue> Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ref var entry = ref entries[index];
                return new KeyValuePair<TKey, TValue>(entry.Key, entry.Value);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
        }
    }
}
