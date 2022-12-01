using System;
using System.Linq;
using StructLinq.Range;
using Xunit;

namespace StructLinq.Tests
{
    public class MaxTests
    {
        [Theory]
        [InlineData(int.MaxValue, 10)]
        [InlineData(-10, 10)]
        [InlineData(0, 10)]
        [InlineData(10, 10)]
        public void MaxTest(int end, int count)
        {
            var array = Enumerable.Range(end - count, count).ToArray();

            var max = array.ToStructEnumerable().Max();

            var expected = array.Max();

            Assert.Equal(expected, max);
        }

        [Theory]
        [InlineData(int.MaxValue, 10)]
        [InlineData(-10, 10)]
        [InlineData(0, 10)]
        [InlineData(10, 10)]
        public void MaxTestOnWhere(int end, int count)
        {
            var array = Enumerable.Range(end - count, count).ToArray();

            var max = array.ToStructEnumerable().Where(x=> true).Max();

            var expected = array.Max();

            Assert.Equal(expected, max);
        }


        [Fact]
        public void ErrorTest()
        {
            var structEnum = Enumerable.Empty<double>().ToStructEnumerable();
            Assert.Throws<ArgumentOutOfRangeException>(() => structEnum.Max());
        }

       
        [Fact]
        public void ErrorTestOnCollection()
        {
            var structEnum = StructEnumerable.Range(0, 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => structEnum.Max());
        }

    }
}