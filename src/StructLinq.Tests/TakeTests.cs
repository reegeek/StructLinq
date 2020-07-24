using System.Linq;
using StructLinq.Range;
using StructLinq.Take;
using Xunit;

namespace StructLinq.Tests
{
    public class TakeTests : AbstractEnumerableTests<int,
        TakeEnumerable<int, RangeEnumerable, RangeEnumerator>,
        TakeEnumerator<int, RangeEnumerator>>
    {
        protected override TakeEnumerable<int, RangeEnumerable, RangeEnumerator> Build(int size)
        {
            return StructEnumerable.Range(-1, size).Take(size, x=> x);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(int takeCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Take(takeCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToStructEnumerable().Take(takeCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
