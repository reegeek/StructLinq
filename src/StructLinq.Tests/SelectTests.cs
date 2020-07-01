using System;
using System.Linq;
using StructLinq.Range;
using StructLinq.Select;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectTests : AbstractEnumerableTests<int,
        IStructEnumerable<int, SelectEnumerator<int, int, RangeEnumerator, StructFunction<int, int>>>,
        SelectEnumerator<int, int, RangeEnumerator, StructFunction<int, int>>>
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

        protected override IStructEnumerable<int, SelectEnumerator<int, int, RangeEnumerator, StructFunction<int, int>>> Build(int size)
        {
            IStructEnumerable<int, SelectEnumerator<int, int, RangeEnumerator, StructFunction<int, int>>> selectEnumerable = StructEnumerable.Range(-1, size).Select(x => x * 2);
            return selectEnumerable;
        }

        struct MultFunction : IFunction<int, double>
        {
            public double Eval(int element)
            {
                return element * 2.0;
            }
        }
    }
}
