using System.Linq;
using StructLinq.Array;
using StructLinq.Concat;
using Xunit;

namespace StructLinq.Tests
{
    public class ConcatTests : AbstractEnumerableTests<
        int,
        ConcatEnumerator<int, ArrayStructEnumerator<int>, ArrayStructEnumerator<int>>>
    {

        protected override StructEnum<int, ConcatEnumerator<int, ArrayStructEnumerator<int>, ArrayStructEnumerator<int>>> Build(int size)
        {
            var size1 = size / 2;
            var size2 = size - size1;
            var array1 = StructEnumerable.Range2(-1, size1).ToArray().ToStructEnum();
            var array2 = StructEnumerable.Range2(-1, size2).ToArray().ToStructEnum();
            return array1.Concat(array2);
        }

        [Fact]
        public void ShouldSameAsSystem()
        {
            var array1 = StructEnumerable.Range2(-1, 15).ToArray();
            var array2 = StructEnumerable.Range2(-1, 10).ToArray();

            var expected = array1.Concat(array2).ToArray();
            var value = array1.ToStructEnum().Concat(array2.ToStructEnum()).ToArray();
            Assert.Equal(expected, value);
        }
    }
}
