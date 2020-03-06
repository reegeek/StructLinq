using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;


namespace StructLinq.Tests
{
    public class RangeTests : AbstractEnumerableTests<int>
    {
        protected override IEnumerable<int> Build(int size)
        {
            return StructEnumerable.Range(-1, size).ToEnumerable();
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void ShouldBeEqualToSystem(int start, int count)
        {
            var system = Enumerable.Range(start, count);
            var structEnum = StructEnumerable.Range(start, count).ToEnumerable();
            structEnum.Should().Equal(system);
        }
    }

}
