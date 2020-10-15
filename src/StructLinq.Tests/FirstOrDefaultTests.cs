using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class FirstOrDefaultTests
    {
        [Fact]
        public void ShouldReturnFirstElement()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToStructEnumerable()
                                  .FirstOrDefault()
                                  .Should()
                                  .Be(0);
        }

        [Fact]
        public void ShouldReturnFirstElementZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToStructEnumerable()
                                  .FirstOrDefault(x=>x)
                                  .Should()
                                  .Be(0);
        }

        [Fact]
        public void ShouldReturnDefault()
        {
            StructEnumerable.Empty<int>().FirstOrDefault().Should().Be(default);
        }

        [Fact]
        public void ShouldReturnDefaultZeroAlloc()
        {
            StructEnumerable.Empty<int>().FirstOrDefault(x=>x).Should().Be(default);
        }


        [Fact]
        public void ShouldReturnFirstElementWithFunc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToStructEnumerable()
                                  .FirstOrDefault(x=> x > 5)
                                  .Should()
                                  .Be(6);
        }

        [Fact]
        public void ShouldReturnFirstElementWithFuncZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToStructEnumerable()
                                  .FirstOrDefault(x=> x > 5, x=> x)
                                  .Should()
                                  .Be(6);
        }
    }
}
