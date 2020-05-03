using System.Linq;
using StructLinq.Array;
using Xunit;

namespace StructLinq.Tests
{
    public class ListTests : AbstractEnumerableTests<int, ArrayEnumerable<int>, ArrayStructEnumerator<int>>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToList().ToStructEnumerable().ToEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        protected override ArrayEnumerable<int> Build(int size)
        {
            var list = Enumerable.Range(-1, size).ToList();
            return list.ToStructEnumerable();
        }
    }
}