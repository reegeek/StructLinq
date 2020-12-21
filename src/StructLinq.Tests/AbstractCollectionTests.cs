using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public abstract class AbstractCollectionTests<T, TStructCollection, TEnumerator> 
        : AbstractEnumerableTests<T, TStructCollection, TEnumerator> 
        where TStructCollection : struct, IStructCollection<T, TEnumerator>
        where TEnumerator : struct, ICollectionEnumerator<T>
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

        [Theory]
        [InlineData(10, 2)]
        [InlineData(7, 5)]
        [InlineData(7, 0)]
        [InlineData(7, 10)]
        public void ShouldSkipWithVisitor(int size, int skip)
        {
            TStructCollection collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var list = new List<T>();
            var visitor = new ListVisitor<T>(list);
            
            collection.Skip(skip, x => x)
                                   .Visit(ref visitor);

            
            var values = list.ToArray();
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
            IStructCollection<T, TEnumerator> collection = Build(size);
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
        public void ShouldTakeWithVisitor(int size, int take)
        {
            TStructCollection collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var list = new List<T>();
            var visitor = new ListVisitor<T>(list);

            collection.Take(take, x => x)
                                   .Visit(ref visitor);

            var values = list.ToArray();
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
            IStructCollection<T, TEnumerator> collection = Build(size);
            var array = collection.ToEnumerable().ToArray();

            var values = collection.Take(take, x => x).ToArray();

            var expected = array.Take((int) take).ToArray();

            Assert.Equal(expected, values);
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
            IStructCollection<T, TEnumerator> collection = Build(size);
            var expected = collection.ToEnumerable().ToArray();

            //Act
            var values = collection.ToArray();

            //Assert
            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldReturnIthElement()
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
