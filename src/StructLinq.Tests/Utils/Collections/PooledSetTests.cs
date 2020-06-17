using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using StructLinq.Utils.Collections;
using Xunit;

namespace StructLinq.Tests.Utils.Collections
{
    public class PooledSetTests
    {
        [Fact]
        public void ShouldIncreaseCapacity()
        {
            var equalityComparer = EqualityComparer<int>.Default;
            var set = new PooledSet<int, IEqualityComparer<int>>(0, 
                ArrayPool<int>.Shared, 
                ArrayPool<Slot<int>>.Shared, 
                equalityComparer);

            var array = Enumerable.Range(0, 100).ToArray();
            foreach (var i in array)
            {
                set.AddIfNotPresent(i).Should().BeTrue();
            }

            foreach (var i in array)
            {
                set.AddIfNotPresent(i).Should().BeFalse();
            }
        }
    }
}