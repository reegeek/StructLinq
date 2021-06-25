#if !NETSTANDARD1_1
using System.Runtime.CompilerServices;

namespace StructLinq.Dictionary
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

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => length + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TValue Get(int i)
        {
            ref var entry = ref entries[start + i];
            return entry.Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TValue>
        {
            var count = Count;
            var s = start;
            var array = entries;
            for (int i = 0; i < count; i++)
            {
                ref var entry = ref array[s+i];
                if (!visitor.Visit(entry.Value))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }

    }
}
#endif