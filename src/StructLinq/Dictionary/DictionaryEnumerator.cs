#if !NETSTANDARD1_1
using StructLinq.Utils;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Dictionary
{
    public struct DictionaryEnumerator<TKey, TValue> : ICollectionEnumerator<KeyValuePair<TKey, TValue>>
    {
        private readonly Entry<TKey, TValue>[] entries;
        private int length;
        private int start;
        private int index;

        internal DictionaryEnumerator(Entry<TKey, TValue>[] entries, int start, int count)
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

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => length + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public KeyValuePair<TKey, TValue> Get(int i)
        {
            ref var entry = ref entries[start + i];
            return new KeyValuePair<TKey, TValue>(entry.Key, entry.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<KeyValuePair<TKey, TValue>>
        {
            var count = Count;
            var s = start;
            var array = entries;
            for (int i = 0; i < count; i++)
            {
                ref var input = ref array[s + i];
                if (!visitor.Visit(new KeyValuePair<TKey, TValue>(input.Key, input.Value)))
                    return VisitStatus.VisitorFinished;
            }
            return VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int) start + this.start;
                if (length.HasValue)
                    this.length = (int) length.Value + this.start;
            }
        }
    }
}
#endif