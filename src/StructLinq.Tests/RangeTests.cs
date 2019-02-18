using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class RangeTests
    {
        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void CompareToSystem(int start, int count)
        {
            var system = Enumerable.Range(start, count);
            var structEnum = StructEnumerable.Range(start, count);
            Assert.Equal(system, structEnum);
        }
    }

}
