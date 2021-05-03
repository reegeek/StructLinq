using System.Collections.Generic;
using System.Linq;
using StructLinq.Except;
using StructLinq.Range;
using Xunit;

namespace StructLinq.Tests
{
    public class ExceptTests : AbstractEnumerableTests<int,
        ExceptEnumerable<int, RangeEnumerable, RangeEnumerable, RangeEnumerator, RangeEnumerator, EqualityComparer<int>>,
        ExceptEnumerator<int, RangeEnumerator, RangeEnumerator, EqualityComparer<int>>>
    {
        protected override ExceptEnumerable<int, RangeEnumerable, RangeEnumerable, RangeEnumerator, RangeEnumerator, EqualityComparer<int>> Build(int size)
        {
            var enum1 = StructEnumerable.Range(0, size);
            var enum2 = StructEnumerable.Range(size + 10, size);
            var comparer = EqualityComparer<int>.Default;
            return enum1.Except(enum2, comparer, x => x, x => x);
        }

        [Fact]
        public void SameAsSystem()
        {
            var array1 = new int[] { 1, 1, 2, 3, 4, 4, 5 };
            var array2 = new int[] { 4, 5, 6, 6, 7, 8, 9 };

            var expected = array1.Except(array2).ToArray();
            var value = array1.ToStructEnumerable().Except(array2.ToStructEnumerable()).ToArray();
            Assert.Equal(expected, value);
        }

        [Fact]
        public void SameAsSystemEnumerable()
        {
            var array1 = new int[] { 1, 1, 2, 3, 4, 4, 5 };
            var array2 = new int[] { 4, 5, 6, 6, 7, 8, 9 };

            var expected = array1.Except(array2);
            var value = array1.ToStructEnumerable().Except(array2.ToStructEnumerable()).ToEnumerable();
            Assert.Equal(expected, value);
        }
    }
}