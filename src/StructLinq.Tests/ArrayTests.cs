using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class ArrayTests
    {
        [Fact]
        public void Test()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToArray().ToTypedEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }
    }
}