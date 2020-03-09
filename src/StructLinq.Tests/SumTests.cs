using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class SumTests
    {
        [Fact]
        public void StructTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Sum();
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void ZeroAllocStructTest()
        {
            var sys = Enumerable
                      .Range(-50, 100)
                      .Sum();
            var structEnum = StructEnumerable
                             .Range(-50, 100)
                             .Sum(x=> x);
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void ConvertTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToStructEnumerable()
                .Sum();
            Assert.Equal(sys, structEnum);
        }
    }
}