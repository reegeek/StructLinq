using System;
using System.Linq;
using StructLinq.Range;
using StructLinq.Select;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectCollectionFuncTests : AbstractCollectionTests<double,
        SelectCollection<int, double, RangeEnumerable, RangeEnumerator>,
        SelectCollectionEnumerator<int, double, RangeEnumerator>>
    {
        [Fact]
        public void DelegateTest()
        {
            Func<int, double> selector = x => x * 2.0;
            var sys = Enumerable
                .Range(-50, 100)
                .Select(selector)
                .ToArray();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Select(selector)
                .ToEnumerable()
                .ToArray();
            Assert.Equal(sys, structEnum);
        }

        protected override StructCollection<double, SelectCollection<int, double, RangeEnumerable, RangeEnumerator>, SelectCollectionEnumerator<int, double, RangeEnumerator>> BuildCollection(int size)
        {
            var selectEnumerable =
                StructEnumerable.Range(-1, size).Select(x => x * 2.0);
            return selectEnumerable;
        }
    }
}