using System.Linq;
using StructLinq.Array;
using StructLinq.Skip;
using Xunit;

namespace StructLinq.Tests
{
    public class RefSkipTests : AbstractRefEnumerableTests<int,
        RefSkipEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>>,
        RefSkipEnumerator<int, ArrayRefStructEnumerator<int>>>
    {
        protected override RefSkipEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>> Build(int size)
        {
            return StructEnumerable.Range(-1, size + 5).ToArray().ToRefStructEnumerable().Skip(5, x=> x);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(uint skipCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Skip((int)skipCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToRefStructEnumerable().Skip(skipCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
