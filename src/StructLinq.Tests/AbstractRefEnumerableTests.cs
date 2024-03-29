﻿using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public abstract class AbstractRefEnumerableTests<T, TStructEnumerable, TEnumerator>
        where TStructEnumerable : IRefStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        protected bool shouldReturnSameSequenceWhenResetIsCall = true;
        protected abstract TStructEnumerable Build(int size);

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldSizeEqual(int size)
        {
            //Arrange
            var enumerable = Build(size);

            //Act
            int enumSize = enumerable.ToEnumerable().Count();

            //Assert
            size.Should().Be(enumSize);
        }

        //[Fact]
        //public void ShouldReturnDefaultWhenMoveNextIsNeverCall()
        //{
        //    //Arrange
        //    var enumerable = Build(2);

        //    //Act
        //    T current;
        //    using (var enumerator = enumerable.GetEnumerator())
        //    {
        //        current = enumerator.Current;
        //    }

        //    //Assert
        //    current.Should().Be(default(T));
        //}

        [Fact]
        public void ShouldReturnFalseWhenCallingMoveNextAfterLastElement()
        {
            //Arrange
            var enumerable = Build(5);
            //Act
            using (var enumerator = enumerable.ToEnumerable().GetEnumerator())
            {
                while (enumerator.MoveNext())
                {

                }

                var moveNext = enumerator.MoveNext();
                moveNext.Should().BeFalse();
            }
        }

        //[Fact]
        //public void ShouldReturnLastElementWhenCallCurrentAfterMoveNextIsFalse()
        //{
        //    Arrange
        //    var enumerable = Build(1);
        //    Act
        //    using (var enumerator = enumerable.GetEnumerator())
        //    {
        //        enumerator.MoveNext();
        //        var last = enumerator.Current;
        //        var moveNext = enumerator.MoveNext();
        //        var current = enumerator.Current;
        //        moveNext.Should().BeFalse();
        //        last.Should().Be(current);
        //    }
        //}

        [Fact]
        public void ShouldReturnSameSequenceWhenEnumeratorIsCall2Times()
        {
            //Arrange
            var enumerable = Build(5);
            //Act
            var array1 = enumerable.ToEnumerable().ToArray();
            var array2 = enumerable.ToEnumerable().ToArray();
            //Assert
            array1.Should().Equal(array2);
        }

        [Fact]
        public void ShouldReturnSameSequenceWhenResetIsCall()
        {
            if (!shouldReturnSameSequenceWhenResetIsCall)
                return;
            //Arrange
            var enumerable = Build(5);

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
                while (enumerator.MoveNext())
                {
                    list.Add(enumerator.Current);
                }
                return list;
            }
        }

        [Fact]
        public void ShouldUseDuckTypingCompatibilityForForEach()
        {
            var structArray = Build(5);
            var count = 0;
            foreach (ref var i in structArray)
            {
                count += 1;
            }
            Assert.Equal(5, count);
        }

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

    }
}