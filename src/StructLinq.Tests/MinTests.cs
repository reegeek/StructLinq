using System;
using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class MinTests
    {
        [Fact]
        public void MinTest()
        {
            var count = 100;
            var mult = -2.0;
            var structMin = StructEnumerable
                .Range(0, count)
                .Select(x => x * mult, x=>x)
                .Min();
            Assert.Equal((count - 1) * mult, structMin);
        }

        [Fact]
        public void MinTest2()
        {
            var count = 100;
            var mult = -2.0;
            var structMin = StructEnumerable
                            .Range(0, count)
                            .Select(x => x * mult, x => x)
                            .Min(x=>x);
            Assert.Equal((count - 1) * mult, structMin);
        }


        [Fact]
        public void ErrorTest()
        {
            var structEnum = Enumerable.Empty<double>().ToStructEnumerable();
            Assert.Throws<ArgumentOutOfRangeException>(() => structEnum.Min());
        }
    }
}