using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class CollectionLastTests
    {
        [Fact]
        public void ShouldReturnLastElement()
        {
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToStructEnumerable()
                .Last()
                .Should()
                .Be(9);
        }

        [Fact]
        public void ShouldReturnLastElementZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToStructEnumerable()
                .Last(x => x)
                .Should()
                .Be(9);
        }

        [Fact]
        public void ShouldThrowException()
        {
            Assert.Throws<Exception>(() => StructEnumerable.Empty<int>().Last());
        }

        [Fact]
        public void ShouldThrowExceptionZeroAlloc()
        {
            Assert.Throws<Exception>(() => StructEnumerable.Empty<int>().Last(x => x));
        }


        [Fact]
        public void ShouldReturnLastElementWithFunc()
        {
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToStructEnumerable()
                .Last(x => x > 5)
                .Should()
                .Be(9);
        }

        [Fact]
        public void ShouldReturnLastElementWithFuncZeroAlloc()
        {
            var array = Enumerable.Range(0, 10)
                .ToArray()
                .ToStructEnumerable()
                .Last(x => x > 5, x => x)
                .Should()
                .Be(9);
        }
    }
}