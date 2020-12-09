using System.Linq;
using StructLinq.BCL.Hashset;
using Xunit;

namespace StructLinq.Tests
{
    public class HashsetTests : AbstractCollectionTests<int,
        HashsetEnumerable<int>,
        HashsetEnumerator<int>>
    {
        protected override HashsetEnumerable<int> Build(int size)
        {
            return Enumerable
                   .Range(-1, size)
                   .ToHashSet()
                   .ToStructEnumerable();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(50)]
        public void ShouldSameAsSystem(int size)
        {
            var dictionary = Enumerable
                             .Range(0, size)
                             .ToHashSet();
            var sysArray = dictionary
                           .AsEnumerable()
                           .ToArray();
            var structArray = Enumerable
                              .Range(0, size)
                              .ToHashSet()
                              .ToStructEnumerable()
                              .ToEnumerable()
                              .ToArray();
            Assert.Equal(sysArray, structArray);
        }

        [Fact]
        public void ShouldHandleAddElementAfterEnumerableWasCreated()
        {
            var dictionary = Enumerable.Range(0, 50).ToHashSet();
            var structList = dictionary.ToStructEnumerable();
            dictionary.Add(50);

            var expected = Enumerable.Range(0, 51)
                                     .ToHashSet()
                                     .AsEnumerable()
                                     .ToArray();
            var enumerable = structList.ToEnumerable().ToArray();
            Assert.Equal(expected, enumerable);
        }

    }
}
