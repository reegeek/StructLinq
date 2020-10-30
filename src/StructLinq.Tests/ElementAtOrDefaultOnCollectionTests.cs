using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class ElementAtOrDefaultOnCollectionTests
    {
        [Fact]
        public void ShouldReturnElementAtElement()
        {
            var enumerable = Enumerable.Range(-1, 10)
                                       .ToArray()
                                       .ToStructEnumerable();
            var array = enumerable.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Assert.Equal(array[i], enumerable.ElementAtOrDefault(i));
            }
        }

        [Fact]
        public void ShouldReturnElementAtElementZeroAlloc()
        {
            var enumerable = Enumerable.Range(-1, 10)
                                       .ToArray()
                                       .ToStructEnumerable();
            var array = enumerable.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Assert.Equal(array[i], enumerable.ElementAtOrDefault(i, x=>x));
            }
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-1)]
        [InlineData(10)]
        [InlineData(20)]
        public void ShouldReturnDefault(int index)
        {
            var enumerable = Enumerable.Range(-1, 10)
                                       .ToArray()
                                       .ToStructEnumerable();
            Assert.Equal(default,  enumerable.ElementAtOrDefault(index));
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-1)]
        [InlineData(10)]
        [InlineData(20)]
        public void ShouldReturnDefaultZeroAlloc(int index)
        {
            var enumerable = Enumerable.Range(-1, 10)
                                       .ToArray()
                                       .ToStructEnumerable();
            Assert.Equal(default,  enumerable.ElementAtOrDefault(index, x=>x));
        }
    }
}
