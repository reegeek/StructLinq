using System.Linq;
using StructLinq.Dictionary;
using Xunit;

namespace StructLinq.Tests
{
    public class KeyDictionaryTests : AbstractCollectionTests<int,
        DictionaryKeyEnumerable<int, string>,
        DictionaryKeyEnumerator<int, string>>
    {
        protected override DictionaryKeyEnumerable<int, string> Build(int size)
        {
            return Enumerable
                   .Range(-1, size)
                   .ToDictionary(x => x, x => x.ToString())
                   .ToStructKeyEnumerable();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(50)]
        public void ShouldSameAsSystem(int size)
        {
            var sysArray = Enumerable
                           .Range(0, size)
                           .ToDictionary(x => x.ToString(), x => x.ToString())
                           .Keys
                           .AsEnumerable()
                           .ToArray();
            var structArray = Enumerable
                              .Range(0, size)
                              .ToDictionary(x => x.ToString(), x => x.ToString())
                              .ToStructKeyEnumerable()
                              .ToEnumerable()
                              .ToArray();
            Assert.Equal(sysArray, structArray);
        }

        [Fact]
        public void ShouldHandleAddElementAfterEnumerableWasCreated()
        {
            var dictionary = Enumerable.Range(0, 50).ToDictionary(x => x, x => x.ToString());
            var structValueEnumerable = dictionary.ToStructKeyEnumerable();
            dictionary.Add(50, "50");

            var expected = Enumerable.Range(0, 51)
                                     .ToDictionary(x => x, x => x.ToString())
                                     .Keys
                                     .AsEnumerable()
                                     .ToArray();
            var enumerable = structValueEnumerable.ToEnumerable().ToArray();
            Assert.Equal(expected, enumerable);
        }
    }
}
