using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class RefLastTests
    {
        [Fact]
        public void ShouldReturnLastElement()
        {
            int last = default;
            Enumerable.Range(0, 10)
                .ToArray()
                .ToRefStructEnumerable()
                .TryLast(ref last)
                .Should()
                .BeTrue();
            last.Should().Be(9);
        }

        [Fact]
        public void ShouldReturnLastElementZeroAlloc()
        {
            int last = default;
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToRefStructEnumerable()
                .TryLast(ref last, x=>x)
                .Should()
                .BeTrue();
            last.Should().Be(9);
        }

        [Fact]
        public void ShouldThrowException()
        {
            int last = default;
            StructEnumerable.Empty<int>()
                .ToArray()
                .ToRefStructEnumerable()
                .TryLast(ref last)
                .Should()
                .BeFalse();
        }

        [Fact]
        public void ShouldThrowExceptionZeroAlloc()
        {
            int last = default;
            StructEnumerable.Empty<int>()
                .ToArray()
                .ToRefStructEnumerable()
                .TryLast(ref last, x=>x)
                .Should()
                .BeFalse();
        }


        [Fact]
        public void ShouldReturnLastElementWithFunc()
        {
            int last = default;
            Enumerable.Range(0, 10)
                .ToArray()
                .ToRefStructEnumerable()
                .TryLast(x=> x > 5, ref last)
                .Should()
                .BeTrue();
            last.Should().Be(9);
        }

        [Fact]
        public void ShouldReturnLastElementWithFuncZeroAlloc()
        {
            int last = default;
            Enumerable.Range(0, 10)
                .ToArray()
                .ToRefStructEnumerable()
                .TryLast(x => x > 5, ref last, x=> x)
                .Should()
                .BeTrue();
            last.Should().Be(9);
        }
    }
}