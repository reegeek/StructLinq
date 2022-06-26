using System.Runtime.CompilerServices;
using StructLinq.Range;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<int, RangeEnumerable, RangeEnumerator> Range(int start, int count)
        {
            return new StructCollection<int, RangeEnumerable, RangeEnumerator>(new RangeEnumerable(start, count));
        }
    }
}