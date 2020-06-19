using System.Buffers;
using System.Linq;
using FluentAssertions;
using StructLinq.Utils.Collections;
using Xunit;

namespace StructLinq.Tests.Utils.Collections
{
    public class InPooledSetTests
    {
        [Fact]
        public void ShouldIncreaseCapacity()
        {
            var set = new InPooledSet<int, IInEqualityComparer<int>>(0, 
                                                                     ArrayPool<int>.Shared, 
                                                                     ArrayPool<Slot<int>>.Shared, 
                                                                     InEqualityComparer<int>.Default);

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
