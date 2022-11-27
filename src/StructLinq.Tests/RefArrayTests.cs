﻿using System.Linq;
using FluentAssertions;
using StructLinq.Array;
using Xunit;

namespace StructLinq.Tests
{
    public class RefArrayTests : AbstractRefCollectionTests<int, ArrayRefStructEnumerator<int>>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToArray().ToRefStructEnumerable().ToEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        protected override RefStructCollec<int, ArrayRefStructEnumerator<int>> BuildCollection(int size)
        {
            return Enumerable.Range(-1, size).ToArray().ToRefStructEnum();
        }

        [Fact]
        public void ShouldOverrideValue()
        {
            var array = Enumerable.Range(0, 50).ToArray();
            var structArray = array.ToRefStructEnumerable();
            foreach (ref var v in structArray)
            {
                v = -1;
            }

            foreach (var i in array)
            {
                i.Should().Be(-1);
            }
        }
    }
}