using System.Linq;
using StructLinq.Array;
using StructLinq.Take;
using Xunit;

namespace StructLinq.Tests
{
    public class RefTakeTests : AbstractRefEnumerableTests<int,
        RefTakeEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>>,
        RefTakeEnumerator<int, ArrayRefStructEnumerator<int>>>
    {
        protected override RefTakeEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>> Build(int size)
        {
            return StructEnumerable.Range(-1, size).ToArray().ToRefStructEnumerable().Take(size, x=> x);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(int takeCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Take((int)takeCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToRefStructEnumerable().Take(takeCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
