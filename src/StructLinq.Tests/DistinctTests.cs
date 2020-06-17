﻿using System.Collections.Generic;
using System.Linq;
using StructLinq.Distinct;
using StructLinq.Range;
using Xunit;

namespace StructLinq.Tests
{
    public class DistinctTests : AbstractEnumerableTests<int,
        DistinctEnumerable<int, RangeEnumerable, RangeEnumerator, IEqualityComparer<int>>,
        DistinctEnumerator<int, RangeEnumerator, IEqualityComparer<int>>>
    {
        protected override DistinctEnumerable<int, RangeEnumerable, RangeEnumerator, IEqualityComparer<int>> Build(int size)
        {
            var selectEnumerable = StructEnumerable.Range(-1, size).Distinct(x=>x);
            return selectEnumerable;
        }

        [Fact]
        public void ShouldEquals()
        {
            var expected = Enumerable.Range(0, 100)
                .Select(x => x % 10)
                .Distinct();

            var value = Enumerable.Range(0, 100)
                .Select(x => x % 10)
                .ToStructEnumerable()
                .Distinct(x=> x)
                .ToEnumerable();
            Assert.Equal(expected, value);
        }
    }
}