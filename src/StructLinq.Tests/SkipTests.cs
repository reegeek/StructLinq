using System.Linq;
using StructLinq.Range;
using StructLinq.Skip;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class SkipTests : AbstractEnumerableTests<int,
        SkipEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator>, WhereEnumerator<int, RangeEnumerator>>,
        SkipEnumerator<int, WhereEnumerator<int, RangeEnumerator>>>
    {
        protected override StructEnumerable<int, SkipEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator>, WhereEnumerator<int, RangeEnumerator>>, SkipEnumerator<int, WhereEnumerator<int, RangeEnumerator>>> Build(int size)
        {
            var skipEnumerable = StructEnumerable.Range(-1, size + 5).Where(_ => true).Skip(5);
            return skipEnumerable;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(int skipCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Skip(skipCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToStructEnumerable().Where(_=> true).Skip(skipCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
