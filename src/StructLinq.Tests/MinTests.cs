using System;
using System.Linq;
using StructLinq.Range;
using Xunit;

namespace StructLinq.Tests
{
    public class MinTests
    {
        [Theory]
        [InlineData(int.MinValue, 10)]
        [InlineData(-10, 10)]
        [InlineData(0, 10)]
        [InlineData(10, 10)]
        public void MinTest(int start, int count)
        {
            var array = Enumerable.Range(start, count).ToArray();

            var structMin = array.ToStructEnumerable().Min();
            var expected = array.Min();
            Assert.Equal(expected, structMin);
        }

        [Theory]
        [InlineData(int.MinValue, 10)]
        [InlineData(-10, 10)]
        [InlineData(0, 10)]
        [InlineData(10, 10)]
        public void MinTestOnWhre(int start, int count)
        {
            var array = Enumerable.Range(start, count).ToArray();

            var structMin = array.ToStructEnumerable().Where(x=> true).Min();
            var expected = array.Min();
            Assert.Equal(expected, structMin);
        }


        [Fact]
        public void ErrorTestOnCollection()
        {
            var structEnum = StructEnumerable.Range(0, 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => structEnum.Min(x=> x));
        }

        [Fact]
        public void ErrorTest()
        {
            var structEnum = Enumerable.Empty<double>().ToStructEnumerable();
            Assert.Throws<ArgumentOutOfRangeException>(() => structEnum.Min());
        }

    }
}