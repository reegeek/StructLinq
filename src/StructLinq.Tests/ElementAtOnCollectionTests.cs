using System;
using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class ElementAtOnCollectionTests
    {
        [Fact]
        public void ShouldReturnElementAtElement()
        {
            var enumerable = Enumerable.Range(-1, 10)
                                       .ToArray()
                                       .ToStructEnumerable();
            var array = enumerable.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Assert.Equal(array[i], enumerable.ElementAt(i));
            }
        }

        [Fact]
        public void ShouldReturnElementAtElementZeroAlloc()
        {
            var enumerable = Enumerable.Range(-1, 10)
                                       .ToArray()
                                       .ToStructEnumerable();
            var array = enumerable.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Assert.Equal(array[i], enumerable.ElementAt(i, x=>x));
            }
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-1)]
        [InlineData(10)]
        [InlineData(20)]
        public void ShouldThrowException(int index)
        {
            var enumerable = Enumerable.Range(-1, 10)
                                       .ToArray()
                                       .ToStructEnumerable();
            Assert.Throws<ArgumentOutOfRangeException>(() => enumerable.ElementAt(index));
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-1)]
        [InlineData(10)]
        [InlineData(20)]
        public void ShouldThrowExceptionZeroAlloc(int index)
        {
            var enumerable = Enumerable.Range(-1, 10)
                                       .ToArray()
                                       .ToStructEnumerable();
            Assert.Throws<ArgumentOutOfRangeException>(() => enumerable.ElementAt(index, x=>x));
        }
    }
}
