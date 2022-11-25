using System.Linq;
using StructLinq.Array;
using Xunit;

namespace StructLinq.Tests
{
    public class ArrayTests : AbstractCollectionTests<int, ArrayStructEnumerator<int>>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToArray().ToStructEnum().ToEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        protected override StructCollec<int, ArrayStructEnumerator<int>> BuildCollection(int size)
        {
            return Enumerable.Range(-1, size).ToArray().ToStructEnum();
        }
    }
}