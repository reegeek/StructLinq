﻿using System.Linq;
using StructLinq.Array;
using Xunit;

namespace StructLinq.Tests
{
    public class ArrayTests : AbstractEnumerableTests<int, ArrayStructEnumerator<int>>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToArray().ToStructEnum().ToEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        protected override StructEnum<int, ArrayStructEnumerator<int>> Build(int size)
        {
            return Enumerable.Range(-1, size).ToArray().ToStructEnum();
        }
    }
}