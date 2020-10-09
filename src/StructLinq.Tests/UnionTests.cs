using System.Collections.Generic;
using System.Linq;
using StructLinq.Range;
using StructLinq.Union;
using Xunit;

namespace StructLinq.Tests
{
    public class UnionTests : AbstractEnumerableTests<int,
        UnionEnumerable<int, RangeEnumerable, RangeEnumerable, RangeEnumerator, RangeEnumerator, EqualityComparer<int>>,
        UnionEnumerator<int, RangeEnumerator, RangeEnumerator, EqualityComparer<int>>>
    {
        protected override UnionEnumerable<int, RangeEnumerable, RangeEnumerable, RangeEnumerator, RangeEnumerator, EqualityComparer<int>> Build(int size)
        {
            var size1 = size / 2;
            var size2 = size - size1;
            var enum1 = StructEnumerable.Range(0, size1);
            var enum2 = StructEnumerable.Range(size1 + 10, size2);
            var comparer = EqualityComparer<int>.Default;
            return enum1.Union(enum2, comparer, x => x, x => x);
        }

        [Fact]
        public void SameAsSystem()
        {
            var array1 = new int[] { 1, 1, 2, 3, 4, 4, 5 };
            var array2 = new int[] { 4, 5, 6, 6, 7, 8, 9 };

            var expected = array1.Union(array2).ToArray();
            var value = array1.ToStructEnumerable().Union(array2.ToStructEnumerable()).ToArray();
            Assert.Equal(expected, value);
        }
    }
}
