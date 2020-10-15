using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class RefFirstTests
    {
        [Fact]
        public void ShouldReturnFirstElement()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToRefStructEnumerable()
                                  .First()
                                  .Should()
                                  .Be(0);
        }

        [Fact]
        public void ShouldReturnFirstElementZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToRefStructEnumerable()
                                  .First(x=>x)
                                  .Should()
                                  .Be(0);
        }

        [Fact]
        public void ShouldThrowException()
        {
            Assert.Throws<Exception>(() => StructEnumerable.Empty<int>().ToArray().ToRefStructEnumerable().First());
        }

        [Fact]
        public void ShouldThrowExceptionZeroAlloc()
        {
            Assert.Throws<Exception>(() => StructEnumerable.Empty<int>().ToArray().ToRefStructEnumerable().First(x=>x));
        }


        [Fact]
        public void ShouldReturnFirstElementWithFunc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToRefStructEnumerable()
                                  .First(x=> x > 5)
                                  .Should()
                                  .Be(6);
        }

        [Fact]
        public void ShouldReturnFirstElementWithFuncZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                                  .ToArray()
                                  .ToRefStructEnumerable()
                                  .First(x=> x > 5, x=> x)
                                  .Should()
                                  .Be(6);
        }
    }
}
