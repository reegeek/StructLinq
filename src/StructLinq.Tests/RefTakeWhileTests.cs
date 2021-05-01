using System.Linq;
using StructLinq.Array;
using StructLinq.TakeWhile;
using Xunit;

namespace StructLinq.Tests
{
    public class RefTakeWhileTests : AbstractRefEnumerableTests<int,
        RefTakeWhileEnumerable<int, StructInFunction<int, bool>, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>>,
        RefTakeWhileEnumerator<int, StructInFunction<int, bool>, ArrayRefStructEnumerator<int>>>
    {

        protected override RefTakeWhileEnumerable<int, StructInFunction<int, bool>, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>> Build(int size)
        {
            var enumerable = StructEnumerable.Range(-1, size).ToArray().ToRefStructEnumerable().TakeWhile((in int _) => true, x=>x);
            return enumerable;
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(5, 3)]
        [InlineData(10, 5)]
        [InlineData(10, 15)]
        public void ShouldBeTheSameAsSystem(int max, int limit)
        {
            var expected = Enumerable.Range(0, max).ToArray().TakeWhile(x => x > limit).ToArray();
            var value = Enumerable.Range(0, max).ToArray().ToRefStructEnumerable().TakeWhile((in int x) => x > limit).ToArray();

            Assert.Equal(expected, value);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(5, 3)]
        [InlineData(10, 5)]
        [InlineData(10, 15)]
        public void ShouldBeTheSameAsSystemViaEnumerable(int max, int limit)
        {
            var expected = Enumerable.Range(0, max).ToArray().TakeWhile(x => x > limit).ToArray();
            var value = Enumerable.Range(0, max).ToArray().ToRefStructEnumerable().TakeWhile((in int x) => x > limit).ToEnumerable().ToArray();

            Assert.Equal(expected, value);
        }

    }
}