using System.Linq;
using StructLinq.Array;
using StructLinq.Distinct;
using Xunit;

namespace StructLinq.Tests
{
    public class RefDistinctTests : AbstractRefEnumerableTests<int,
        RefDistinctEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, DefaultStructInEqualityComparer>,
        RefDistinctEnumerator<int, ArrayRefStructEnumerator<int>, DefaultStructInEqualityComparer>>
    {
        protected override RefDistinctEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, DefaultStructInEqualityComparer> Build(int size)
        {
            var selectEnumerable = Enumerable.Range(-1, size).ToArray().ToRefStructEnumerable().Distinct(x => x);
            return selectEnumerable;
        }

        [Fact]
        public void ShouldEquals()
        {
            var expected = Enumerable.Range(0, 100)
                                     .Select(x => x % 10)
                                     .Distinct();

            var value = Enumerable.Range(0, 100)
                                  .Select(x => x % 10)
                                  .ToArray()
                                  .ToRefStructEnumerable()
                                  .Distinct(x => x)
                                  .ToEnumerable();
            Assert.Equal(expected, value);
        }
    }
}
