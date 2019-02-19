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
        public void ConvertTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToTypedEnumerable()
                .Sum();
            Assert.Equal(sys, structEnum);
        }
    }
}