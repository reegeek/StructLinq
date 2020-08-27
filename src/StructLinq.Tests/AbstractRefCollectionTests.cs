using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public abstract class AbstractRefCollectionTests<T, TStructCollection, TEnumerator>
        : AbstractRefEnumerableTests<T, TStructCollection, TEnumerator>
        where TStructCollection : struct, IRefStructCollection<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldDirectCountEqual(int size)
        {
            //Arrange
            var enumerable = Build(size);

            //Act
            int enumSize = enumerable.Count();

            //Assert
            enumSize.Should().Be(size);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldToArray(int size)
        {
            //Arrange
            var collection = Build(size);
            var expected = collection.ToEnumerable().ToArray();

            //Act
            var values = collection.ToArray(x=>x);

            //Assert
            Assert.Equal(expected, values);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldToArrayWithInterface(int size)
        {
            //Arrange
            IRefStructCollection<T, TEnumerator> collection = Build(size);
            var expected = collection.ToEnumerable().ToArray();

            //Act
            var values = collection.ToArray();

            //Assert
            Assert.Equal(expected, values);
        }
    }
}
