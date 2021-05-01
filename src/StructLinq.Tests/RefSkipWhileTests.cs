using System.Linq;
using StructLinq.Array;
using StructLinq.SkipWhile;
using Xunit;

namespace StructLinq.Tests
{
    public class RefSkipWhileTests : AbstractRefEnumerableTests<int,
        RefSkipWhileEnumerable<int, StructInFunction<int, bool>, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>>,
        RefSkipWhileEnumerator<int, StructInFunction<int, bool>, ArrayRefStructEnumerator<int>>>
    {

        protected override RefSkipWhileEnumerable<int, StructInFunction<int, bool>, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>> Build(int size)
        {
            var skipEnumerable = StructEnumerable.Range(-1, size).ToArray().ToRefStructEnumerable().SkipWhile((in int _) => false, x=>x);
            return skipEnumerable;
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(5, 3)]
        [InlineData(10, 5)]
        [InlineData(10, 15)]
        public void ShouldBeTheSameAsSystem(int max, int limit)
        {
            var expected = Enumerable.Range(0, max).ToArray().SkipWhile(x => x < limit).ToArray();
            var value = Enumerable.Range(0, max).ToArray().ToRefStructEnumerable().SkipWhile((in int x) => x < limit).ToArray();

            Assert.Equal(expected, value);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(5, 3)]
        [InlineData(10, 5)]
        [InlineData(10, 15)]
        public void ShouldBeTheSameAsSystemViaEnumerable(int max, int limit)
        {
            var expected = Enumerable.Range(0, max).ToArray().SkipWhile(x => x < limit).ToArray();
            var value = Enumerable.Range(0, max).ToArray().ToRefStructEnumerable().SkipWhile((in int x) => x < limit).ToEnumerable().ToArray();

            Assert.Equal(expected, value);
        }

    }
}