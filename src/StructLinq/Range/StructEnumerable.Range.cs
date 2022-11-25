using System.Runtime.CompilerServices;
using StructLinq.Range;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollec<int,RangeEnumerator> Range2(int start, int count)
        {
            return new (new(start, count));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RangeEnumerable Range(int start, int count)
        {
            return new RangeEnumerable(start, count);
        }
    }
}