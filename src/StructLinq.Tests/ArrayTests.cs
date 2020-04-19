using System.Linq;
using StructLinq.Array;
using Xunit;

namespace StructLinq.Tests
{
    public class ArrayTests : AbstractEnumerableTests<int, ArrayEnumerable<int>, ArrayStructEnumerator<int>>
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

        [Fact]
        public void ShouldUseDuckTypingCompatibilityForForEach()
        {
            var structArray = Build(5);
            var count = 0;
            foreach (var i in structArray)
            {
                count += 1;
            }
            Assert.Equal(5, count);
        }

    }
}