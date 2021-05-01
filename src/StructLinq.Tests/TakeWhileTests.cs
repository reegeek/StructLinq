using System.Linq;
using StructLinq.Range;
using StructLinq.TakeWhile;
using Xunit;

namespace StructLinq.Tests
{
    public class TakeWhileTests : AbstractEnumerableTests<int,
        TakeWhileEnumerable<int, StructFunction<int, bool>, RangeEnumerable, RangeEnumerator>,
        TakeWhileEnumerator<int, StructFunction<int, bool>, RangeEnumerator>>
    {

        protected override TakeWhileEnumerable<int, StructFunction<int, bool>, RangeEnumerable, RangeEnumerator> Build(int size)
        {
            var takeEnumerable = StructEnumerable.Range(-1, size).TakeWhile(x => true, x => x);
            return takeEnumerable;
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(10, 5)]
        [InlineData(10, 15)]
        public void ShouldBeTheSameAsSystem(int max, int limit)
        {
            var expected = Enumerable.Range(0, max).ToArray().TakeWhile(x => x > limit).ToArray();
            var value = Enumerable.Range(0, max).ToArray().ToStructEnumerable().TakeWhile(x => x > limit).ToArray();

            Assert.Equal(expected, value);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(10, 5)]
        [InlineData(10, 15)]
        public void ShouldBeTheSameAsSystemViaEnumerable(int max, int limit)
        {
            var expected = Enumerable.Range(0, max).ToArray().TakeWhile(x => x > limit).ToArray();
            var value = Enumerable.Range(0, max).ToArray().ToStructEnumerable().TakeWhile(x => x > limit).ToEnumerable().ToArray();

            Assert.Equal(expected, value);
        }
    }
}