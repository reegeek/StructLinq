using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public struct StructInEqualityComparer<T> : IInEqualityComparer<T>
    {
        private readonly IEqualityComparer<T> comparer;

        public StructInEqualityComparer(IEqualityComparer<T> comparer)
        {
            this.comparer = comparer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(in T x, in T y)
        {
            return comparer.Equals(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetHashCode(in T obj)
        {
            return comparer.GetHashCode(obj);
        }
    }
}
