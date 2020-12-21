using System.Linq;
using StructLinq.Range;
using StructLinq.Reverse;
using Xunit;

namespace StructLinq.Tests
{
    public class ReverseStructCollectionTests : AbstractCollectionTests<
        int,
        ReverseStructCollection<int, RangeEnumerable, RangeEnumerator>,
        ReverseEnumerator<int, RangeEnumerator>>
    {

        protected override
            ReverseStructCollection<int, RangeEnumerable, RangeEnumerator> Build(int size)
        {
            ReverseStructCollection<int, RangeEnumerable, RangeEnumerator> reverseStructCollection = StructEnumerable.Range(0, size).Reverse(x => x);
            return reverseStructCollection;
        }

        [Fact]
        public void ShouldBeEqualToSystem()
        {
            var reverseEnumerable = StructEnumerable.Range(0, 100).Reverse(x => x).ToArray();
            var expected = Enumerable.Range(0, 100).Reverse().ToArray();
            Assert.Equal(expected, reverseEnumerable);
        }
    }
}