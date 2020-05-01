using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class RefSumTests
    {
        [Fact]
        public void StructTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToArray()
                .ToRefStructEnumerable()
                .Sum();
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void ZeroAllocStructTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToArray()
                .ToRefStructEnumerable()
                .Sum(x => x);
            Assert.Equal(sys, structEnum);
        }
    }
}