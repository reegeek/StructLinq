using System.Buffers;
using System.Linq;
using StructLinq.Utils.Collections;
using Xunit;

namespace StructLinq.Tests.Utils.Collections
{
    public class PooledListVisitorTests
    {
        [Fact]
        public void ShouldCopyArray()
        {
            var visitor = new PooledListVisitor<int>(0, ArrayPool<int>.Shared);
            var array = Enumerable.Range(-1, 50).ToArray();

            array.ToStructEnumerable().Visit(ref visitor);

            var value = visitor.PooledList.ToArray();
            Assert.Equal(array, value);
        }
    }
}
