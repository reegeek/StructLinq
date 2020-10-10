using System.Collections.Generic;
using System.Linq;
using StructLinq.Intersect;
using StructLinq.Range;
using Xunit;

namespace StructLinq.Tests
{
    public class IntersectTests : AbstractEnumerableTests<int,
        IntersectEnumerable<int, RangeEnumerable, RangeEnumerable, RangeEnumerator, RangeEnumerator, EqualityComparer<int>>,
        IntersectEnumerator<int, RangeEnumerator, RangeEnumerator, EqualityComparer<int>>>
    {
        protected override IntersectEnumerable<int, RangeEnumerable, RangeEnumerable, RangeEnumerator, RangeEnumerator, EqualityComparer<int>> Build(int size)
        {
            var enum1 = StructEnumerable.Range(0, size);
            var enum2 = StructEnumerable.Range(0, size);
            var comparer = EqualityComparer<int>.Default;
            return enum1.Intersect(enum2, comparer, x => x, x => x);
        }

        [Fact]
        public void SameAsSystem()
        {
            var array1 = new int[] { 1, 1, 2, 3, 4, 4, 5 };
            var array2 = new int[] { 4, 5, 6, 6, 7, 8, 9 };

            var expected = array1.Intersect(array2).ToArray();
            var value = array1.ToStructEnumerable().Intersect(array2.ToStructEnumerable()).ToArray();
            Assert.Equal(expected, value);
        }
    }
}