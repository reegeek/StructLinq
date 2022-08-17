using System;
using System.Linq;
using StructLinq.Range;
using StructLinq.Select;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectFuncTests : AbstractEnumerableTests<double,
        SelectEnumerable<int, double, WhereEnumerable<int, RangeEnumerable, RangeEnumerator>, WhereEnumerator<int, RangeEnumerator>>,
        SelectEnumerator<int, double, WhereEnumerator<int, RangeEnumerator>>>
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

        protected override StructEnumerable<double, SelectEnumerable<int, double, WhereEnumerable<int, RangeEnumerable, RangeEnumerator>, WhereEnumerator<int, RangeEnumerator>>, SelectEnumerator<int, double, WhereEnumerator<int, RangeEnumerator>>> Build(int size)
        {
            var selectEnumerable =
                StructEnumerable.Range(-1, size).Where(x => true).Select(x => x * 2.0);
            return selectEnumerable;

        }
    }

}
