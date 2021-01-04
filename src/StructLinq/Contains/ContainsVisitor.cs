using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Contains
{
    readonly struct ContainsVisitor<T, TComparer> : IVisitor<T>
        where TComparer : IEqualityComparer<T>
    {
        private readonly TComparer comparer;
        private readonly T x;
        public ContainsVisitor(TComparer comparer, T x)
        {
            this.comparer = comparer;
            this.x = x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            return !comparer.Equals(x, input);
        }
    }
}