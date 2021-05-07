using System;
using System.Linq;
using StructLinq.Range;
using StructLinq.Select;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectFuncTests : AbstractEnumerableTests<double,
        SelectEnumerable<int, double, IStructEnumerable<int, RangeEnumerator>, RangeEnumerator>,
        SelectEnumerator<int, double, RangeEnumerator>>
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

        protected override SelectEnumerable<int, double, IStructEnumerable<int, RangeEnumerator>, RangeEnumerator> Build(int size)
        {
            IStructEnumerable<int, RangeEnumerator> rangeEnumerable = StructEnumerable.Range(-1, size);
            var selectEnumerable = 
                rangeEnumerable.Select(x=> x * 2.0);
            return selectEnumerable;
        }

    }

}
