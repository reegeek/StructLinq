using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class LastOrDefaultTests
    {
        [Fact]
        public void ShouldReturnLastElement()
        {
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToStructEnumerable()
                .LastOrDefault()
                .Should()
                .Be(9);
        }

        [Fact]
        public void ShouldReturnLastElementZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToStructEnumerable()
                .LastOrDefault(x => x)
                .Should()
                .Be(9);
        }

        [Fact]
        public void ShouldReturnDefault()
        {
            StructEnumerable.Empty<int>().LastOrDefault().Should().Be(default);
        }

        [Fact]
        public void ShouldReturnDefaultZeroAlloc()
        {
            StructEnumerable.Empty<int>().LastOrDefault(x => x).Should().Be(default);
        }


        [Fact]
        public void ShouldReturnLastElementWithFunc()
        {
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToStructEnumerable()
                .LastOrDefault(x => x > 5)
                .Should()
                .Be(9);
        }

        [Fact]
        public void ShouldReturnLastElementWithFuncZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToStructEnumerable()
                .LastOrDefault(x => x > 5, x => x)
                .Should()
                .Be(9);
        }
    }
}