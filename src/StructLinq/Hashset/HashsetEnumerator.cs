#if !NETSTANDARD1_1
using System.Runtime.CompilerServices;

namespace StructLinq.Hashset
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
#if (NETCOREAPP3_0_OR_GREATER)
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

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => length + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
        {
            ref var entry = ref entries[start + i];
            return entry.Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var count = Count;
            var s = start;
            var array = entries;
            for (int i = 0; i < count; i++)
            {
                ref var input = ref array[s+i];
                if (!visitor.Visit(input.Value))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;

        }
    }
}
#endif