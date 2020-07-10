using System.Collections.Generic;
using System.Linq;
using StructLinq.Array;
using StructLinq.OrderBy;
using Xunit;

namespace StructLinq.Tests
{
    public class OrderByTests : AbstractEnumerableTests<
        int,
        OrderEnumerable<int, ArrayEnumerable<int>, ArrayStructEnumerator<int>, Comparer<int>>,
        OrderByEnumerator<int>>
    {
        protected override OrderEnumerable<int, ArrayEnumerable<int>, ArrayStructEnumerator<int>, Comparer<int>> Build(int size)
        {
            var array = Enumerable.Range(-1, size).Reverse().ToArray().ToStructEnumerable();
            return array.OrderBy(x => x);
        }

        [Fact]
        public void ShouldBeSameAsSystem()
        {
            var array = Enumerable.Range(0, 100).Reverse().ToArray().ToStructEnumerable();

            var order = array.OrderBy(x => x).ToArray();

            Assert.Equal(Enumerable.Range(0, 100), order);
        }
    }
}
