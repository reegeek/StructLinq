using System.Linq;
using StructLinq.Range;
using StructLinq.Skip;
using Xunit;

namespace StructLinq.Tests
{
    public class SkipTests : AbstractEnumerableTests<int,
        SkipEnumerable<int, RangeEnumerable, RangeEnumerator>,
        SkipEnumerator<int, RangeEnumerator>>
    {
        protected override SkipEnumerable<int, RangeEnumerable, RangeEnumerator> Build(int size)
        {
            return StructEnumerable.Range(-1, size + 5).Skip(5, x=> x);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(uint skipCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Skip((int)skipCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToStructEnumerable().Skip(skipCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
