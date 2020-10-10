using System.Linq;
using StructLinq.Array;
using StructLinq.Intersect;
using Xunit;

namespace StructLinq.Tests
{
    public class RefIntersectTests : AbstractRefEnumerableTests<int,
        RefIntersectEnumerable<int, ArrayRefEnumerable<int>, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, ArrayRefStructEnumerator<int>, StructInEqualityComparer<int>>,
        RefIntersectEnumerator<int, ArrayRefStructEnumerator<int>, ArrayRefStructEnumerator<int>, StructInEqualityComparer<int>>>
    {
        protected override RefIntersectEnumerable<int, ArrayRefEnumerable<int>, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, ArrayRefStructEnumerator<int>, StructInEqualityComparer<int>> Build(int size)
        {
            var enum1 = StructEnumerable.Range(0, size).ToArray().ToRefStructEnumerable();
            var enum2 = StructEnumerable.Range(0, size).ToArray().ToRefStructEnumerable();
            var comparer = InEqualityComparer<int>.Default;
            return enum1.Intersect(enum2, comparer, x => x, x => x);
        }

        [Fact]
        public void SameAsSystem()
        {
            var array1 = new int[] { 1, 1, 2, 3, 4, 4, 5 };
            var array2 = new int[] { 4, 5, 6, 6, 7, 8, 9 };

            var expected = array1.Intersect(array2).ToArray();
            var value = array1.ToRefStructEnumerable().Intersect(array2.ToRefStructEnumerable()).ToArray();
            Assert.Equal(expected, value);
        }
    }
}