using System.Linq;
using StructLinq.Array;
using StructLinq.Concat;
using Xunit;

namespace StructLinq.Tests
{
    public class RefConcatTests : AbstractRefEnumerableTests<
        int,
        RefConcatEnumerable<int, ArrayRefEnumerable<int>, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, ArrayRefStructEnumerator<int>>,
        RefConcatEnumerator<int, ArrayRefStructEnumerator<int>, ArrayRefStructEnumerator<int>>>
    {
        protected override RefConcatEnumerable<int, ArrayRefEnumerable<int>, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, ArrayRefStructEnumerator<int>> Build(int size)
        {
            var size1 = size / 2;
            var size2 = size - size1;
            var array1 = StructEnumerable.Range(-1, size1).ToArray().ToRefStructEnumerable();
            var array2 = StructEnumerable.Range(-1, size2).ToArray().ToRefStructEnumerable();
            return array1.Concat(array2, x => x, x => x);
        }

        [Fact]
        public void ShouldSameAsSystem()
        {
            var array1 = StructEnumerable.Range(-1, 15).ToArray();
            var array2 = StructEnumerable.Range(-1, 10).ToArray();

            var expected = array1.Concat(array2).ToArray();
            var value = array1.ToRefStructEnumerable().Concat(array2.ToRefStructEnumerable(), x => x, x => x).ToArray();
            Assert.Equal(expected, value);
        }

        [Fact]
        public void ShouldSameAsSystemWithInterface()
        {
            var array1 = StructEnumerable.Range(-1, 15).ToArray();
            var array2 = StructEnumerable.Range(-1, 10).ToArray();

            var expected = array1.Concat(array2).ToArray();
            var value = array1.ToRefStructEnumerable().Concat(array2.ToRefStructEnumerable()).ToArray();
            Assert.Equal(expected, value);
        }

    }
}
