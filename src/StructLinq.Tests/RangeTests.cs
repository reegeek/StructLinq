﻿using System.Linq;
using Xunit;
using FluentAssertions;
using StructLinq.Range;


namespace StructLinq.Tests
{
    public class RangeTests : AbstractCollectionTests<int, RangeEnumerable, RangeEnumerator>
    {
        protected override StructCollection<int, RangeEnumerable, RangeEnumerator> BuildCollection(int size)
        {
            return StructEnumerable.Range(-1, size);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void ShouldBeEqualToSystem(int start, int count)
        {
            var system = Enumerable.Range(start, count);
            var structEnum = StructEnumerable.Range(start, count).ToEnumerable();
            structEnum.Should().Equal(system);
        }
    }

}
