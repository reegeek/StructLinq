using System.Runtime.CompilerServices;

namespace StructLinq.Count
{
    internal struct CountVisitor<T> : IVisitor<T>
    {
        public int count;
        public CountVisitor(int count)
        {
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            count++;
            return true;
        }
    }
}