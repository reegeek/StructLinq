using System.Linq;
using FluentAssertions;
using StructLinq.Array;
using StructLinq.List;
using Xunit;

namespace StructLinq.Tests
{
    public class RefListTests : AbstractRefCollectionTests<int, ListRefEnumerable<int>, ArrayRefStructEnumerator<int>>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToList().ToRefStructEnumerable().ToEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        [Fact]
        public void ShouldHandleAddElementAfterEnumerableWasCreated()
        {
            var list = Enumerable.Range(0, 50).ToList();
            var structList = list.ToRefStructEnumerable();
            list.Add(50);

            var expected = Enumerable.Range(0, 51).ToArray();
            var actual = structList.ToEnumerable().ToArray();
            Assert.Equal(expected, actual);
        }

        protected override ListRefEnumerable<int> Build(int size)
        {
            return Enumerable.Range(-1, size).ToList().ToRefStructEnumerable();
        }

        [Fact]
        public void ShouldOverrideValue()
        {
            var list = Enumerable.Range(0, 50).ToList();
            var structArray = list.ToRefStructEnumerable();
            foreach (ref var v in structArray)
            {
                v = -1;
            }

            foreach (var i in list)
            {
                i.Should().Be(-1);
            }
        }
    }
}