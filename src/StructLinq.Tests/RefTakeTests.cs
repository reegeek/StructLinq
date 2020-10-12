using System.Linq;
using StructLinq.Array;
using StructLinq.Take;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class RefTakeTests : AbstractRefEnumerableTests<int,
        RefTakeEnumerable<int, RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>, RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>>,
        RefTakeEnumerator<int, RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>>>
    {
        protected override RefTakeEnumerable<int, RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>, RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>>  Build(int size)
        {
            var refTakeEnumerable = StructEnumerable.Range(-1, size).ToArray().ToRefStructEnumerable().Where((in int x)=> true, x=>x).Take(size, x=> x);
            return refTakeEnumerable;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(int takeCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Take((int)takeCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToRefStructEnumerable().Take(takeCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
