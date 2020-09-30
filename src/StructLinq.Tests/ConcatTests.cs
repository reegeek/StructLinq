using System.Linq;
using StructLinq.Array;
using StructLinq.Concat;
using StructLinq.Empty;
using Xunit;

namespace StructLinq.Tests
{
    public class ConcatTests : AbstractEnumerableTests<
        int,
        ConcatEnumerable<int, ArrayEnumerable<int>, ArrayEnumerable<int>, ArrayStructEnumerator<int>, ArrayStructEnumerator<int>>,
        ConcatEnumerator<int, ArrayStructEnumerator<int>, ArrayStructEnumerator<int>>>
    {
        protected override ConcatEnumerable<int, ArrayEnumerable<int>, ArrayEnumerable<int>, ArrayStructEnumerator<int>, ArrayStructEnumerator<int>> Build(int size)
        {
            var size1 = size / 2;
            var size2 = size - size1;
            var array1 = StructEnumerable.Range(-1, size1).ToArray().ToStructEnumerable();
            var array2 = StructEnumerable.Range(-1, size2).ToArray().ToStructEnumerable();
            return array1.Concat(array2, x => x, x => x);
        }

        [Fact]
        public void ShouldSameAsSystem()
        {
            var array1 = StructEnumerable.Range(-1, 15).ToArray();
            var array2 = StructEnumerable.Range(-1, 10).ToArray();

            var expected = array1.Concat(array2).ToArray();
            var value = array1.ToStructEnumerable().Concat(array2.ToStructEnumerable(), x => x, x => x).ToArray();
            Assert.Equal(expected, value);
        }

        [Fact]
        public void ShouldSameAsSystemWithInterface()
        {
            var array1 = StructEnumerable.Range(-1, 15).ToArray();
            var array2 = StructEnumerable.Range(-1, 10).ToArray();

            var expected = array1.Concat(array2).ToArray();
            var value = array1.ToStructEnumerable().Concat(array2.ToStructEnumerable()).ToArray();
            Assert.Equal(expected, value);
        }

    }
}
