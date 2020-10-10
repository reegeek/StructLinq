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

        [Fact]
        public void ShouldRemove()
        {
            var equalityComparer = InEqualityComparer<int>.Default;
            var set = new InPooledSet<int, IInEqualityComparer<int>>(0,
                ArrayPool<int>.Shared,
                ArrayPool<Slot<int>>.Shared,
                equalityComparer);

            var array = Enumerable.Range(0, 100).ToArray();
            foreach (var i in array)
            {
                set.AddIfNotPresent(i).Should().BeTrue();
            }

            foreach (var i in Enumerable.Range(-10, 9))
            {
                set.Remove(i).Should().BeFalse();
            }

            foreach (var i in Enumerable.Range(0, 50))
            {
                set.Remove(i).Should().BeTrue();
            }

            foreach (var i in Enumerable.Range(50, 50))
            {
                set.AddIfNotPresent(i).Should().BeFalse();
            }
        }

        [Fact]
        public void ShouldAddAndRemove()
        {
            var equalityComparer = InEqualityComparer<int>.Default;
            var set = new InPooledSet<int, IInEqualityComparer<int>>(0,
                ArrayPool<int>.Shared,
                ArrayPool<Slot<int>>.Shared,
                equalityComparer);

            set.AddIfNotPresent(1);
            set.Remove(1).Should().BeTrue();
            set.Remove(1).Should().BeFalse();

        }
    }
}
