using System.Linq;
using StructLinq.Range;
using StructLinq.Take;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class TakeTests : AbstractEnumerableTests<int,
        TakeEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator, StructFunction<int, bool>>, WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>>,
        TakeEnumerator<int, WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>>>
    {
        protected override TakeEnumerable<int, WhereEnumerable<int, RangeEnumerable, RangeEnumerator, StructFunction<int, bool>>, WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>> Build(int size)
        {
            return StructEnumerable.Range(-1, size).Where(x=>true, x=>x).Take((uint)size, x=> x);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(uint takeCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Take((int)takeCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToStructEnumerable().Take(takeCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
