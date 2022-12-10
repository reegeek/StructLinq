using FluentAssertions;
using StructLinq.Range;
using Xunit;

namespace StructLinq.Tests
{
    public class ContainsTests
    {
        [Fact]
        public void ShouldReturnTrue()
        {
            var enumerable = StructEnumerable.Range2(0, 100);
            for (int i = 0; i < 100; i++)
            {
                enumerable.Contains(i).Should().BeTrue();
            }
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            var enumerable = StructEnumerable.Range2(0, 100);
            enumerable.Contains(-10).Should().BeFalse();
        }
    }
}
