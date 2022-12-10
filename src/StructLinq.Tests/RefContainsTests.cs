using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class RefContainsTests
    {
        [Fact]
        public void ShouldReturnTrue()
        {
            var enumerable = StructEnumerable.Range(0, 100).ToArray().ToRefStructEnum();
            for (int i = 0; i < 100; i++)
            {
                enumerable.Contains(i).Should().BeTrue();
            }
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            var enumerable = StructEnumerable.Range(0, 100).ToArray().ToRefStructEnum();
            enumerable.Contains(-10).Should().BeFalse();
        }
    }
}
