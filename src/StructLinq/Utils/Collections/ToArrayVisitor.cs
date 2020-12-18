using System.Runtime.CompilerServices;

namespace StructLinq.Utils.Collections
{
    internal struct ToArrayVisitor<T> : IVisitor<T>
    {
        public T[] Array;
        private int index;
        public ToArrayVisitor(int size)
        {
            Array = new T[size];
            index = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            Array[index++] = input;
            return true;
        }
    }
}
