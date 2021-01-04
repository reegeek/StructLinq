using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class ContainsStringTests
    {
        [Fact]
        public void ShouldReturnTrue()
        {
            var enumerable = StructEnumerable.Range(0, 100).Select(x=> x.ToString());
            for (int i = 0; i < 100; i++)
            {
                enumerable.Contains(i.ToString(), x => x).Should().BeTrue();
            }
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            var enumerable = StructEnumerable.Range(0, 100).Select(x=> x.ToString());
            enumerable.Contains((-10).ToString(), x => x).Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnFalseWithInterface()
        {
            var enumerable = StructEnumerable.Range(0, 100).Select(x=> x.ToString());
            enumerable.Contains((-10).ToString()).Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueWithInterface()
        {
            var enumerable = StructEnumerable.Range(0, 100).Select(x=> x.ToString());
            for (int i = 0; i < 100; i++)
            {
                enumerable.Contains(i.ToString()).Should().BeTrue();
            }
        }
    }
}