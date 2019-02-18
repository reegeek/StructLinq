using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class ToTypedEnumerableTests
    {
        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void Test(int start, int count)
        {
            var sys = Enumerable.Range(start, count);
            var structEnum = sys.ToTypedEnumerable();
            Assert.Equal(sys, structEnum);
        }
    }
}