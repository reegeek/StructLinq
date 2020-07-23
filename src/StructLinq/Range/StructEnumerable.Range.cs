using System.Runtime.CompilerServices;
using StructLinq.Range;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RangeEnumerable Range(int start, int count)
        {
            return new RangeEnumerable(start, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count(RangeEnumerable rangeEnumerable)
        {
            return rangeEnumerable.Count;
        }
    }
}