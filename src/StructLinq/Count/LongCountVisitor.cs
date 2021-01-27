using System.Runtime.CompilerServices;

namespace StructLinq.Count
{
    internal struct LongCountVisitor<T> : IVisitor<T>
    {
        public long Count;

        public LongCountVisitor(long count)
        {
            Count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            Count++;
            return true;
        }
    }
}
