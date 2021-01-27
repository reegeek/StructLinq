using System.Runtime.CompilerServices;

namespace StructLinq.Count
{
    internal struct IntCountVisitor<T> : IVisitor<T>
    {
        public int Count;

        public IntCountVisitor(int count)
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
