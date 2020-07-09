using System.Buffers;
using System.Linq;
using StructLinq.Utils.Collections;
using Xunit;

namespace StructLinq.Tests.Utils.Collections
{
    public class PooledListTests
    {
        [Fact]
        public void ShouldIncreaseCapacity()
        {
            var list = new PooledList<int>(0, ArrayPool<int>.Shared);
            var count = 100;
            var array = Enumerable.Range(0, count).ToArray();
            foreach (var i in array)
            {
                list.Add(i);
            }

            Assert.Equal(count, list.Size);
            for (int i = 0; i < count; i++)
            {
                Assert.Equal(list.Items[i], array[i]);
            }
        }

        [Fact]
        public void ShouldIncreaseCapacityWithRef()
        {
            var list = new PooledList<int>(0, ArrayPool<int>.Shared);
            var count = 100;
            var array = Enumerable.Range(0, count).ToArray();
            for (int i = 0; i < count; i++)
            {
                list.Add(ref array[i]);
            }

            Assert.Equal(count, list.Size);
            for (int i = 0; i < count; i++)
            {
                Assert.Equal(list.Items[i], array[i]);
            }
        }

    }
}
