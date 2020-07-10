using System.Linq;
using StructLinq.Range;
using StructLinq.Reverse;
using Xunit;

namespace StructLinq.Tests
{
    public class ReverseTests : AbstractEnumerableTests<
        int,
        ReverseEnumerable<int, RangeEnumerable, RangeEnumerator>,
        ReverseEnumerator<int>>
    {
        protected override ReverseEnumerable<int, RangeEnumerable, RangeEnumerator> Build(int size)
        {
            return StructEnumerable.Range(0, size).Reverse(x=>x);
        }

        [Fact]
        public void ShouldBeEqualToSystem()
        {
            var reverseEnumerable = StructEnumerable.Range(0, 100).Reverse(x=>x).ToArray();
            var expected = Enumerable.Range(0, 100).Reverse().ToArray();
            Assert.Equal(expected, reverseEnumerable);
        }
    }
}
