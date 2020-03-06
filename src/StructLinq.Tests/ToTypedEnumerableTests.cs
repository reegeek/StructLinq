using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class ToTypedEnumerableTests : AbstractEnumerableTests<int>
    {
        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void Test(int start, int count)
        {
            var sys = Enumerable.Range(start, count);
            var structEnum = sys.ToStructEnumerable().ToEnumerable();
            Assert.Equal(sys, structEnum);
        }
        protected override IEnumerable<int> Build(int size)
        {
            return StructEnumerable.Range(-1, size).ToEnumerable();
        }
    }
}