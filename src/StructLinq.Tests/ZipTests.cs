using System.Linq;
using StructLinq.Range;
using StructLinq.Zip;
using Xunit;

namespace StructLinq.Tests
{
    public class ZipTests : AbstractEnumerableTests<(int, int),
        ZipEnumerable<int, RangeEnumerable, RangeEnumerator, int, RangeEnumerable, RangeEnumerator>,
        ZipEnumerator<int, RangeEnumerator, int, RangeEnumerator>>
    {
        protected override ZipEnumerable<int, RangeEnumerable, RangeEnumerator, int, RangeEnumerable, RangeEnumerator> Build(int size)
        {
            return new(StructEnumerable.Range(-10, size), StructEnumerable.Range(10, size));
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(10, 0)]
        [InlineData(5, 10)]
        [InlineData(10, 5)]
        [InlineData(10, 10)]
        public void ShouldBeTheSameAsSystem(int size1, int size2)
        {
            var array1 = Enumerable.Range(-10, size1).ToArray();
            var array2 = Enumerable.Range(-20, size2).ToArray();
            var expected = array1.Zip(array2, (x, y)=> (x, y)).ToArray();
            var values = array1.ToStructEnumerable()
                               .Zip(array2.ToStructEnumerable(), x => x, x => x)
                               .ToArray();
            Assert.Equal(expected, values);
        }
    }
}
