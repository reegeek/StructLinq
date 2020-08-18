using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public abstract class AbstractCollectionTests<T, TStructCollection, TEnumerator> 
        : AbstractEnumerableTests<T, TStructCollection, TEnumerator> 
        where TStructCollection : IStructCollection<T, TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldCountEqual(int size)
        {
            //Arrange
            var enumerable = Build(size);

            //Act
            int enumSize = enumerable.Count();

            //Assert
            enumSize.Should().Be(size);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(10, 2, 10)]
        [InlineData(10, 11, 5)]
        [InlineData(10, 0, 10)]
        [InlineData(10, 0, 9)]
        [InlineData(10, 0, 100)]
        public void ShouldSlice(int size, uint start, uint length)
        {
            //Arrange
            var collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            //Act
            collection.Slice(start, length);

            //Assert
            var values = collection.ToArray();
            var expected = array.Skip((int)start).Take((int)length).ToArray();
            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldCumulateStartSlice()
        {
            //Arrange
            var collection = Build(10);
            var array = collection.ToEnumerable().ToArray();

            //Act
            collection.Slice(2, 10);
            collection.Slice(3, 10);
 
            //Assert
            var values = collection.ToArray();
            var expected = array.Skip(5).ToArray();
            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldClone()
        {
            //Arrange
            var collection = Build(10);

            //Act
            var obj = collection.Clone();

            //Assert
            Assert.False(object.ReferenceEquals(collection, obj));
            obj.Should().BeOfType<TStructCollection>();
            var clone = (TStructCollection) obj;
            Assert.Equal(collection.ToEnumerable().ToArray(), clone.ToEnumerable().ToArray());
        }
    }
}
