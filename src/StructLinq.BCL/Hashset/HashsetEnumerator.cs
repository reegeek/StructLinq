using System.Runtime.CompilerServices;

namespace StructLinq.BCL.Hashset
{
    public struct HashsetEnumerator<T> : ICollectionEnumerator<T>
    {
        private readonly Slot<T>[] entries;
        private readonly int length;
        private readonly int start;
        private int index;

        internal HashsetEnumerator(Slot<T>[] entries, int start, int count)
        {
            this.entries = entries;
            length = count - 1 + start;
            index = start -1;
            this.start = start;
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
            index = start-1;
        }

        public readonly T Current
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
