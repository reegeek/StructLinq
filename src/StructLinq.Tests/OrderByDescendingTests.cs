using System;
using System.Collections.Generic;
using System.Linq;
using StructLinq.Array;
using StructLinq.OrderBy;
using Xunit;

namespace StructLinq.Tests
{
    public class OrderByDescendingTests : AbstractEnumerableTests<
        int,
        OrderByKeyEnumerable<int, IStructEnumerable<int, ArrayStructEnumerator<int>>, ArrayStructEnumerator<int>, StructFunction<int, int>, int, Comparer<int>>,
        OrderByEnumerator<int>>
    {
        protected override OrderByKeyEnumerable<int, IStructEnumerable<int, ArrayStructEnumerator<int>>, ArrayStructEnumerator<int>, StructFunction<int, int>, int, Comparer<int>> Build(int size)
        {
            var array = Enumerable.Range(-1, size).Reverse().ToArray().ToStructEnumerable();
            Func<int, int> func = x => x;
            var orderByKeyEnumerable = array.OrderByDescending(func);
            return orderByKeyEnumerable;
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

            var order = array.ToStructEnumerable().OrderByDescending(x => x).ToArray();
            var expected = array.OrderByDescending(x => x).ToArray();

            Assert.Equal(expected, order);
        }
    }
}