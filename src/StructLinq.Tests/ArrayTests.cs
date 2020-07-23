using System.Linq;
using StructLinq.Array;
using Xunit;

namespace StructLinq.Tests
{
    public class ArrayTests : AbstractCollectionTests<int, ArrayEnumerable<int>, ArrayStructEnumerator<int>>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToArray().ToStructEnumerable().ToEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        protected override ArrayEnumerable<int> Build(int size)
        {
            return Enumerable.Range(-1, size).ToArray().ToStructEnumerable();
        }
    }
}