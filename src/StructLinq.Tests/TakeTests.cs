using System.Linq;
using StructLinq.Range;
using StructLinq.Take;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class TakeTests : AbstractEnumerableTests<int,
        TakeEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator>, WhereEnumerator<int, RangeEnumerator>>,
        TakeEnumerator<int, WhereEnumerator<int, RangeEnumerator>>>
    {
        protected override StructEnumerable<int, TakeEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator>, WhereEnumerator<int, RangeEnumerator>>, TakeEnumerator<int, WhereEnumerator<int, RangeEnumerator>>> Build(int size)
        {
            return StructEnumerable.Range(-1, size).Where(_ => true).Take(size);
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
