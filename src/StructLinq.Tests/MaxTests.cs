using System;
using System.Linq;
using StructLinq.Range;
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
                .Select(x=> x * mult, x=> (IStructEnumerable<int, RangeEnumerator>) x)
                .Max();
            Assert.Equal((count-1) * mult, structMax);
        }

        [Fact]
        public void MaxTest2()
        {
            var count = 100;
            var mult = 2.0;
            var structMax = StructEnumerable
                            .Range(0, count)
                            .Select(x=> x * mult, x=> (IStructEnumerable<int, RangeEnumerator>)x)
                            .Max(x=>x);
            Assert.Equal((count-1) * mult, structMax);
        }
        
        [Fact]
        public void ErrorTest()
        {
            var structEnum = Enumerable.Empty<double>().ToStructEnumerable();
            Assert.Throws<ArgumentOutOfRangeException>(() => structEnum.Max());
        }

        [Fact]
        public void MaxTestOnCollection()
        {
            var count = 100;
            var mult = 2.0;
            var structMax = StructEnumerable
                .Range(0, count)
                .Select(x=> x * mult, x=> x)
                .Max();
            Assert.Equal((count-1) * mult, structMax);
        }

        [Fact]
        public void MaxTestOnCollection2()
        {
            var count = 100;
            var mult = 2.0;
            var structMax = StructEnumerable
                .Range(0, count)
                .Select(x=> x * mult, x=>x)
                .Max(x=>x);
            Assert.Equal((count-1) * mult, structMax);
        }
        
        [Fact]
        public void ErrorTestOnCollection()
        {
            var structEnum = StructEnumerable.Range(0, 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => structEnum.Max());
        }

    }
}