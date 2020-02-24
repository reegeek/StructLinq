using StructLinq.Range;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static RangeEnumerable Range(int start, int count)
        {
            return new RangeEnumerable(start, count);
        }
    }
}