using System;
using System.Collections.Generic;
using System.Linq;
using StructLinq.Array;
using StructLinq.OrderBy;
using Xunit;

namespace StructLinq.Tests
{
    public class OrderTests : AbstractEnumerableTests<
        int,
        OrderEnumerable<int, ArrayEnumerable<int>, ArrayStructEnumerator<int>, Comparer<int>>,
        OrderByEnumerator<int>>
    {
        protected override OrderEnumerable<int, ArrayEnumerable<int>, ArrayStructEnumerator<int>, Comparer<int>> Build(int size)
        {
            var array = Enumerable.Range(-1, size).Reverse().ToArray().ToStructEnumerable();
            return array.Order(x => x);
        }

        [Fact]
        public void ShouldBeSameAsSystem()
        {
            var rand = new Random(42);
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(rand.Next());
            }
            var array = list.ToArray();

            var order = array.ToStructEnumerable().Order(x => x).ToArray();
            var expected = array.OrderBy(x => x).ToArray();

            Assert.Equal(expected, order);
        }
    }
}
