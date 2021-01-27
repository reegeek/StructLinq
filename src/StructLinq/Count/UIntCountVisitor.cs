using System.Runtime.CompilerServices;

namespace StructLinq.Count
{
    internal struct UIntCountVisitor<T> : IVisitor<T>
    {
        public uint Count;

        public UIntCountVisitor(uint count)
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
