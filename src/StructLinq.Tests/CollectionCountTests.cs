using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class CollectionCountTests
    {
        [Fact]
        public void ShouldReturnIntCount()
        {
            var expected = 100;
            var count = StructEnumerable.Range(0, expected).Count();
            count.Should().Be(expected);
        }

        [Fact]
        public void ShouldReturnIntCount2()
        {
            var expected = 100;
            var count = StructEnumerable.Range(0, expected).Count(x=> x);
            count.Should().Be(expected);
        }

        [Fact]
        public void ShouldReturnUIntCount()
        {
            uint expected = 100;
            var count = StructEnumerable.Range(0, (int) expected).UIntCount();
            count.Should().Be(expected);
        }

        [Fact]
        public void ShouldReturnUIntCount2()
        {
            uint expected = 100;
            var count = StructEnumerable.Range(0, (int) expected).UIntCount(x => x);
            count.Should().Be(expected);
        }

        [Fact]
        public void ShouldReturnLongCount()
        {
            long expected = 100;
            var count = StructEnumerable.Range(0, (int)expected).LongCount();
            count.Should().Be(expected);
        }

        [Fact]
        public void ShouldReturnLongCount2()
        {
            long expected = 100;
            var count = StructEnumerable.Range(0, (int)expected).LongCount(x => x);
            count.Should().Be(expected);
        }

    }
}