using System.Linq;
using FluentAssertions;
using StructLinq.Repeat;
using Xunit;

namespace StructLinq.Tests
{
    public class RepeatTests : AbstractEnumerableTests<int, RepeatEnumerable<int>, RepeatEnumerator<int>>
    {
        protected override RepeatEnumerable<int> Build(int size)
        {
            return StructEnumerable.Repeat(-1, (uint)size);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void ShouldBeEqualToSystem(int element, int count)
        {
            var system = Enumerable.Repeat(element, count);
            var structEnum = StructEnumerable.Repeat(element, (uint)count).ToEnumerable();
            structEnum.Should().Equal(system);
        }
    }
}
