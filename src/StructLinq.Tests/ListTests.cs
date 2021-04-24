using System.Linq;
using StructLinq.Array;
using StructLinq.List;
using Xunit;

namespace StructLinq.Tests
{
    public class ListTests : AbstractCollectionTests<int, ListEnumerable<int>, ArrayStructEnumerator<int>>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToList().ToStructEnumerable().ToEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        [Fact]
        public void ShouldHandleAddElementAfterEnumerableWasCreated()
        {
            var list = Enumerable.Range(0, 50).ToList();
            var structList = list.ToStructEnumerable();
            list.Add(50);

            var expected = Enumerable.Range(0, 51).ToArray();
            var enumerable = structList.ToEnumerable().ToArray();
            Assert.Equal(expected, enumerable);
        }

        protected override ListEnumerable<int> Build(int size)
        {
            var list = Enumerable.Range(-1, size).ToList();
            return list.ToStructEnumerable();
        }
    }
}