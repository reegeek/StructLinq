using System.Linq;
using StructLinq.Range;
using StructLinq.Reverse;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class ReverseTests : AbstractEnumerableTests<
        int,
        ReverseEnumerable<int, WhereEnumerable<int, IStructEnumerable<int, RangeEnumerator>, RangeEnumerator>, WhereEnumerator<int, RangeEnumerator>>,
        ReverseEnumerator<int>>
    {

        protected override
            ReverseEnumerable<int, WhereEnumerable<int, IStructEnumerable<int, RangeEnumerator>, RangeEnumerator>, WhereEnumerator<int, RangeEnumerator>> Build(int size)
        {
            return StructEnumerable.Range(0, size).Where(x => true).Reverse(x => x);
        }

        [Fact]
        public void ShouldBeEqualToSystem()
        {
            var reverseEnumerable = StructEnumerable.Range(0, 100).Where(x=> true).Reverse(x=>x).ToArray();
            var expected = Enumerable.Range(0, 100).Reverse().ToArray();
            Assert.Equal(expected, reverseEnumerable);
        }
    }
}
