using StructLinq.Reverse;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static int Count<T, TEnumerable, TEnumerator>(this ReverseEnumerable<T, TEnumerable, TEnumerator> reverseEnumerable)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return reverseEnumerable.Enumerable.Count(x => x);
        }
    }
}
