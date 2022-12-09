using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public abstract class AbstractRefCollectionTests<T, TEnumerator>
        : AbstractRefEnumerableTests<T, TEnumerator>
        where TEnumerator : struct, IRefCollectionEnumerator<T>
    {
        protected abstract RefStructCollec<T, TEnumerator> BuildCollection(int size);

        protected override RefStructEnum<T, TEnumerator> Build(int size) => BuildCollection(size).ToRefStructEnumerable();

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldDirectCountEqual(int size)
        {
            //Arrange
            var enumerable = BuildCollection(size);

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
            var collection = BuildCollection(size);
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
            var collection = BuildCollection(size);
            var array = collection.ToEnumerable().ToArray();

            //Act
            collection = collection.Slice(start, length);

            //Assert
            var values = collection.ToArray();
            var expected = array.Skip((int)start).Take((int)length).ToArray();
            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldCumulateStartSlice()
        {
            //Arrange
            var collection = BuildCollection(10);
            var array = collection.ToEnumerable().ToArray();

            //Act
            collection = collection.Slice(2, 10);
            collection = collection.Slice(3, 10);
 
            //Assert
            var values = collection.ToArray();
            var expected = array.Skip(5).ToArray();
            Assert.Equal(expected, values);
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldSkipAsEnumerable(int size, int skip)
        {
            var collection = BuildCollection(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Skip(skip).ToArray();

            var expected = array.Skip((int) skip).ToArray();

            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldSkipReturnSameSequenceWhenResetIsCall()
        {
            if (!shouldReturnSameSequenceWhenResetIsCall)
                return;
            //Arrange
            var enumerable = BuildCollection(5).Skip(2);

            //Act
            using (var enumerator = enumerable.ToEnumerable().GetEnumerator())
            {
                var list1 = FillList(enumerator);
                enumerator.Reset();
                var list2 = FillList(enumerator);
                list1.Should().Equal(list2);
            }
            List<T> FillList(IEnumerator<T> enumerator)
            {
                var list = new List<T>();
                enumerator.MoveNext();
                list.Add(enumerator.Current);
                enumerator.MoveNext();
                list.Add(enumerator.Current);
                return list;
            }
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldTakeAsEnumerable(int size, int take)
        {
            var collection = BuildCollection(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Take(take).ToArray();

            var expected = array.Take((int) take).ToArray();

            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldRetunIthElement()
        {
            //Arrange
            var collection = BuildCollection(10);
            var expected = collection.ToEnumerable().ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                collection.Get(i).Should().Be(expected[i]);
            }
        }

        [Fact]
        public void ShouldSkipAndReturnIthElement()
        {
            //Arrange
            var collection = BuildCollection(10).Skip(2);
            var expected = collection.ToEnumerable().ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                collection.Get(i).Should().Be(expected[i]);
            }
        }


    }

    public abstract class AbstractRefCollectionTests<T, TStructCollection, TEnumerator>
        : AbstractRefEnumerableTests<T, TStructCollection, TEnumerator>
        where TStructCollection : struct, IRefStructCollection<T, TEnumerator>
        where TEnumerator : struct, IRefCollectionEnumerator<T>
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
#pragma warning disable CA2013 // Do not use ReferenceEquals with value types
            Assert.False(object.ReferenceEquals(collection, obj));
#pragma warning restore CA2013 // Do not use ReferenceEquals with value types
            obj.Should().BeOfType<TStructCollection>();
            var clone = (TStructCollection) obj;
            Assert.Equal(collection.ToEnumerable().ToArray(), clone.ToEnumerable().ToArray());
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldSkipAsEnumerable(int size, int skip)
        {
            TStructCollection collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Skip(skip, x => x).ToArray();

            var expected = array.Skip((int) skip).ToArray();

            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldSkipReturnSameSequenceWhenResetIsCall()
        {
            if (!shouldReturnSameSequenceWhenResetIsCall)
                return;
            //Arrange
            var enumerable = Build(5).Skip(2);

            //Act
            using (var enumerator = enumerable.ToEnumerable().GetEnumerator())
            {
                var list1 = FillList(enumerator);
                enumerator.Reset();
                var list2 = FillList(enumerator);
                list1.Should().Equal(list2);
            }
            List<T> FillList(IEnumerator<T> enumerator)
            {
                var list = new List<T>();
                enumerator.MoveNext();
                list.Add(enumerator.Current);
                enumerator.MoveNext();
                list.Add(enumerator.Current);
                return list;
            }
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldSkipAsEnumerableWithInterface(int size, int skip)
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
        public void ShouldTakeAsEnumerable(int size, int take)
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
        public void ShouldTakeAsEnumerableWithInterface(int size, int take)
        {
            IRefStructCollection<T, TEnumerator> collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Take(take, x => x).ToArray();

            var expected = array.Take((int) take).ToArray();

            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldRetunIthElement()
        {
            //Arrange
            var collection = Build(10);
            var expected = collection.ToEnumerable().ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                collection.Get(i).Should().Be(expected[i]);
            }
        }

        [Fact]
        public void ShouldSkipAndReturnIthElement()
        {
            //Arrange
            var collection = Build(10).Skip(2);
            var expected = collection.ToEnumerable().ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                collection.Get(i).Should().Be(expected[i]);
            }
        }
    }
}
