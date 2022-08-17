using System.Linq;
using StructLinq.Array;
using StructLinq.Skip;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class RefSkipTests : AbstractRefEnumerableTests<int,
        RefSkipEnumerable<int, RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>, RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>> ,
        RefSkipEnumerator<int, RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>>>
    {
        protected override RefStructEnumerable<int, RefSkipEnumerable<int, RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>, RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>>, RefSkipEnumerator<int, RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>>> Build(int size)
        {
            var refSkipEnumerable = StructEnumerable.Range(-1, size + 5).ToArray().ToRefStructEnumerable().Where((in int _) => true).Skip(5);
            return refSkipEnumerable;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeTheSameAsSystem(int skipCount)
        {
            var expected = Enumerable.Range(0, 7).ToArray().Skip(skipCount).ToArray();
            var value = Enumerable.Range(0, 7).ToArray().ToRefStructEnumerable().Skip(skipCount).ToArray();

            Assert.Equal(expected, value);
        }
    }
}
