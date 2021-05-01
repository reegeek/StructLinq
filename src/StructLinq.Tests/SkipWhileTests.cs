using System.Linq;
using StructLinq.Range;
using StructLinq.SkipWhile;
using Xunit;

namespace StructLinq.Tests
{
    public class SkipWhileTests : AbstractEnumerableTests<int,
        SkipWhileEnumerable<int, StructFunction<int, bool>, RangeEnumerable, RangeEnumerator>,
        SkipWhileEnumerator<int, StructFunction<int, bool>, RangeEnumerator>>
    {

        protected override SkipWhileEnumerable<int, StructFunction<int, bool>, RangeEnumerable, RangeEnumerator> Build(int size)
        {
            var skipEnumerable = StructEnumerable.Range(-1, size).SkipWhile(x => false, x => x);
            return skipEnumerable;
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(10, 5)]
        [InlineData(10, 15)]
        public void ShouldBeTheSameAsSystem(int max, int limit)
        {
            var expected = Enumerable.Range(0, max).ToArray().SkipWhile(x => x < limit).ToArray();
            var value = Enumerable.Range(0, max).ToArray().ToStructEnumerable().SkipWhile(x => x < limit).ToArray();

            Assert.Equal(expected, value);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(10, 5)]
        [InlineData(10, 15)]
        public void ShouldBeTheSameAsSystemViaEnumerable(int max, int limit)
        {
            var expected = Enumerable.Range(0, max).ToArray().SkipWhile(x => x < limit).ToArray();
            var value = Enumerable.Range(0, max).ToArray().ToStructEnumerable().SkipWhile(x => x < limit).ToEnumerable().ToArray();

            Assert.Equal(expected, value);
        }
    }
}
