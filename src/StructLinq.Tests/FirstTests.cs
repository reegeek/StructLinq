using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class FirstTests
    {
        [Fact]
        public void ShouldReturnFirstElement()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToStructEnumerable()
                                  .Where(x=> true)
                                  .First()
                                  .Should()
                                  .Be(0);
        }

        [Fact]
        public void ShouldReturnFirstElementZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToStructEnumerable()
                                  .Where(x=> true, x=> x)
                                  .First(x=>x)
                                  .Should()
                                  .Be(0);
        }

        [Fact]
        public void ShouldThrowException()
        {
            Assert.Throws<Exception>(() => StructEnumerable.Empty<int>().First());
        }

        [Fact]
        public void ShouldThrowExceptionZeroAlloc()
        {
            Assert.Throws<Exception>(() => StructEnumerable.Empty<int>().First(x=>x));
        }


        [Fact]
        public void ShouldReturnFirstElementWithFunc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToStructEnumerable()
                                  .Where(x=> true)
                                  .First(x=> x > 5)
                                  .Should()
                                  .Be(6);
        }

        [Fact]
        public void ShouldReturnFirstElementWithFuncZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToStructEnumerable()
                                  .Where(x=> true, x=>x)
                                  .First(x=> x > 5, x=> x)
                                  .Should()
                                  .Be(6);
        }
    }
}
