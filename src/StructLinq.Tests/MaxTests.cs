using System;
using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class MaxTests
    {
        [Fact]
        public void MaxTest()
        {
            var count = 100;
            var mult = 2.0;
            var structMax = StructEnumerable
                .Range(0, count)
                .Select(x=> x * mult)
                .Max();
            Assert.Equal((count-1) * mult, structMax);
        }
        [Fact]
        public void ErrorTest()
        {
            var structEnum = Enumerable.Empty<double>().ToTypedEnumerable();
            Assert.Throws<ArgumentOutOfRangeException>(() => structEnum.Max());
        }
    }
}