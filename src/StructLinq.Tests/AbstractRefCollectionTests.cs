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

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldSkipAsEnumerable(int size, uint skip)
        {
            TStructCollection collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Skip(skip, x => x).ToArray();

            var expected = array.Skip((int) skip).ToArray();

            Assert.Equal(expected, values);
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldSkipAsEnumerableWithInterface(int size, uint skip)
        {
            IRefStructCollection<T, TEnumerator> collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Skip(skip).ToArray();

            var expected = array.Skip((int) skip).ToArray();

            Assert.Equal(expected, values);
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldTakeAsEnumerable(int size, uint take)
        {
            TStructCollection collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Take(take, x => x).ToArray();

            var expected = array.Take((int) take).ToArray();

            Assert.Equal(expected, values);
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldTakeAsEnumerableWithInterface(int size, uint take)
        {
            IRefStructCollection<T, TEnumerator> collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Take(take, x => x).ToArray();

            var expected = array.Take((int) take).ToArray();

            Assert.Equal(expected, values);
        }

    }
}
