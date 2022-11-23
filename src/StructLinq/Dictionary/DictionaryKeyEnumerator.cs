#if !NETSTANDARD1_1
using System.Runtime.CompilerServices;

namespace StructLinq.Dictionary
{
    public struct DictionaryKeyEnumerator<TKey, TValue> : ICollectionEnumerator<TKey>
    {
        private readonly Entry<TKey, TValue>[] entries;
        private readonly int length;
        private readonly int start;
        private int index;

        internal DictionaryKeyEnumerator(Entry<TKey, TValue>[] entries, int start, int count)
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

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => length + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TKey Get(int i)
        {
            ref var entry = ref entries[start + i];
            return entry.Key;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TKey>
        {
            var count = Count;
            var s = start;
            var array = entries;
            for (int i = 0; i < count; i++)
            {
                ref var entry = ref array[s + i];
                if (!visitor.Visit(entry.Key))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }

    }
}
#endif