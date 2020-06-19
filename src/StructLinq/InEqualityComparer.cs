using System.Collections.Generic;

namespace StructLinq
{
    public class InEqualityComparer<T>
    {
        public static readonly IInEqualityComparer<T> Default = EqualityComparer<T>.Default.ToInEqualityComparer();
    }

    public static class InEqualityComparer
    {
        public static IInEqualityComparer<T> ToInEqualityComparer<T>(this IEqualityComparer<T> comparer)
        {
            return new StructInEqualityComparer<T>(comparer);
        }

        private struct StructInEqualityComparer<T> : IInEqualityComparer<T>
        {
            private readonly IEqualityComparer<T> comparer;

            public StructInEqualityComparer(IEqualityComparer<T> comparer)
            {
                this.comparer = comparer;
            }

            public bool Equals(in T x, in T y)
            {
                return comparer.Equals(x, y);
            }

            public int GetHashCode(in T obj)
            {
                return comparer.GetHashCode(obj);
            }
        }
    }
}
