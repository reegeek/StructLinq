using System.Collections.Generic;
using System.Linq;
using StructLinq.IList;
using Xunit;

namespace StructLinq.Tests
{
    public class IListTests : AbstractCollectionTests<
        int, 
        ListEnumerable<int, IList<int>>, 
        IListEnumerator<int, IList<int>>>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            IList<int> list = Enumerable.Range(0, 50).ToList();
            var sysArray = list.ToArray();
            var structArray = list.ToStructEnumerable().ToEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        protected override StructCollection<int, ListEnumerable<int, IList<int>>, IListEnumerator<int, IList<int>>> BuildCollection(int size)
        {
            IList<int> list = Enumerable.Range(-1, size).ToList();
            return list.ToStructEnumerable();
        }
    }
}