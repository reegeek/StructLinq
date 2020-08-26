using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public class InEqualityComparer<T>
    {
        public static readonly IInEqualityComparer<T> Default = EqualityComparer<T>.Default.ToInEqualityComparer();
    }

    public static class InEqualityComparer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructInEqualityComparer<T> ToInEqualityComparer<T>(this IEqualityComparer<T> comparer)
        {
            return new StructInEqualityComparer<T>(comparer);
        }
    }
}
